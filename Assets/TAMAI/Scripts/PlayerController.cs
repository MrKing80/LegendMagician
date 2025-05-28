using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[�N���X���Ǘ�����N���X
/// ����ҁF�ʈ�
/// </summary>
public class PlayerController : MonoBehaviour, IAttackable
{
    #region �ϐ��Ȃ�

    [SerializeField, Space]
    private EnemyManager _enemyManager = default;

    [SerializeField, Header("�X�e�[�^�X")]
    private PlayerStatus _playerStatus = default;

    [SerializeField, Header("�U���G�t�F�N�g"), Space]
    private List<GameObject> _attackEffects = new();

    [SerializeField, Header("�U���G�t�F�N�g"), Range(0, 4)]
    private int _attackIndex = 0;

    [SerializeField, Header("�U�������𑖂点�邩")]
    private bool _isAttack = true;

    [SerializeField, Header("�T������")]
    private float _maxDistance = 0f;

    [SerializeField, Header("��ԋ߂��G���X�V����ۂ̑ҋ@����")]
    private float _wait = 1f;

    private PlayerMove _playerMove = default;
    private BaceAttribute _baceAttribute = default;

    private Rigidbody _rb = default;

    private Vector3 _enemyDistance = Vector3.zero;

    private IReadOnlyList<GameObject> _enemys = default;

    // �X�e�[�^�X
    private string _name = "";

    private int _currentHp = 0;
    private int _maxHp = 0;

    private float _attackPower = 0f;
    private float _attackSpeed = 0f;
    private float _moveSpeed = 0f;

    #endregion

    public PlayerController(string attributeName)
    {
    }

    private void Start()
    {
        _rb = this.GetComponent<Rigidbody>();

        // �v���C���[�̃X�e�[�^�X���擾
        _name = _playerStatus.Name;
        _maxHp = _playerStatus.HP;
        _currentHp = _maxHp;
        _attackPower = _playerStatus.AttackPower;
        _attackSpeed = _playerStatus.AttackSpeed;
        _moveSpeed = _playerStatus.MoveSpeed;

        // �ړ������擾
        _playerMove = new PlayerMove(_moveSpeed, _rb);

        // �q�I�u�W�F�N�g�Ƃ��Đ���
        Instantiate(_attackEffects[_attackIndex], this.transform.position, Quaternion.identity, this.transform);

        _baceAttribute = new FireAttack("��");

        // �G�l�~�[���X�g���擾
        _enemys = _enemyManager.GetEnemies();

        StartCoroutine(NearestEnemy());

    }

    private void FixedUpdate()
    {
        // �ړ�����
        _playerMove.PlayerMoving();
    }

    private void Update()
    {
        // �v���C���[�̈ړ��Ɋւ�����͏���
        _playerMove.HandleInput();
    }

    /// <summary>
    /// �����U��
    /// </summary>
    /// <param name="target">��ԋ߂��G</param>
    public void Attack(IDamageable target)
    {
        // ���鏈���@��
        //��ԋ߂��G��T�� �Y
        //��ԋ߂��G�Ɉ��Ԋu�ōU�����R���[�`���@�ł���

        Debug.Log($"{_baceAttribute.AttributeName}���@�����I");

    }

    public Vector3 GetEnemy()
    {
        return _enemyDistance;
    }

    #region �R���[�`��

    /// <summary>
    /// ��ԋ߂��G�����Ԋu�ŒT��
    /// </summary>
    private IEnumerator NearestEnemy()
    {
        // �A�^�b�N������true�̏ꍇ
        while (_isAttack == true)
        {
            // �G�����Ȃ��ꍇ�̓X���[
            if (_enemys.Count == 0)
                continue;
                
            // ��ԋ߂��G
            GameObject targetEmemy = default;

            // �G����̂�����������A���̈�̂��擾
            if (_enemys.Count == 1)
            {
                targetEmemy = _enemys[0];
            }

            // �T��������2��
            float maxDistance = _maxDistance * _maxDistance;

            foreach (GameObject enemy in _enemys)
            {
                // �����ƓG�̊Ԃ̋����BsqrMagnitude�̏����̓s����2�悳��Ă���
                // Distance()����SqrMagnitude()�̕����������ǂ��A���x���ǂ�
                float targetDistance = (enemy.transform.position - this.transform.position).sqrMagnitude;

                // maxDistance�̕���������������X���[
                if (maxDistance <= targetDistance)
                    continue;

                // ������maxDistance�ȉ���������A�X�V����
                maxDistance = targetDistance;
                targetEmemy = enemy;

                // ��ԋ߂��G�����o�I�ɂ킩��₷�����邽�ߋL�^
                _enemyDistance = targetEmemy.transform.position;
            }
            print($"{targetEmemy}�Ǝ����Ƃ̎c�苗����{maxDistance / maxDistance}m�ł�");

            // ��ԋ߂��G�̃_���[�W�������Ăяo���A�U������
            IDamageable attackTarget = targetEmemy.GetComponent<IDamageable>();
            Attack(attackTarget);

            // �w�莞�ԑҋ@ 
            yield return new WaitForSeconds(_wait);
            print($"{_wait}�b���ɍX�V�I");
        }
    }
    #endregion

    #region _maxDistance���G�f�B�^��Ō����悤�`�揈��

    private void OnDrawGizmos()
    {
        // �}�[���^�F�œG�T���͈͂�`��
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(this.transform.position, _maxDistance);

        // �F�ň�ԋ߂��G�Ǝ����̊Ԃɐ�������
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(this.transform.position, _enemyDistance);
    }

    #endregion
}
