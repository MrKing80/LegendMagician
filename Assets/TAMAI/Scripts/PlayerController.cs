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
    [SerializeField, Space]
    private EnemyManager _enemyManager = default;

    [SerializeField, Header("�X�e�[�^�X")]
    private PlayerStatus _playerStatus = default;

    [SerializeField, Space]
    private bool _isAttack = true;

    [SerializeField, Space]
    // �ϑ��������E��ێ�
    private float _maxDistance = 0f;

    [SerializeField, Header("��ԋ߂��G���X�V����ۂ̑ҋ@����"), Space]
    private float _wait = 1f;

    private PlayerMove _playerMove = default;
    private BaceAttribute _baceAttribute = default;

    private Rigidbody _rb = default;

    IReadOnlyList<GameObject> _enemys = default;

    private string _name = "";

    private int _currentHp = 0;
    private int _maxHp = 0;

    private float _attackPower = 0f;
    private float _attackSpeed = 0f;
    private float _moveSpeed = 0f;

    private Vector3 _enemyDistance;

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

        // �ړ�����
        _playerMove = new PlayerMove(_moveSpeed, _rb);
        
        _baceAttribute = new FireAttack("��");

        // �G�l�~�[���X�g���擾
        _enemys = _enemyManager.GetEnemies();
        print($"{_enemys.Count}");

        StartCoroutine(NearestEnemy());

    }

    private void FixedUpdate()
    {
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
        // ���鏈��
        //��ԋ߂��G��T��
        //��ԋ߂��G�Ɉ��Ԋu�ōU�����R���[�`��

        Debug.Log($"{_baceAttribute.AttributeName}���@�����I");

    }

    #region �R���[�`��

    /// <summary>
    /// ��ԋ߂��G�����Ԋu�ŒT��
    /// </summary>
    private IEnumerator NearestEnemy()
    {
        while (_isAttack == true)
        {
            // �G�����Ȃ��ꍇ�̓X���[
            if (_enemys.Count == 0)
                continue;
                
            // ��ԋ߂��G
            GameObject targetEmemy = default;

            // �G����̂�����������
            if (_enemys.Count == 1)
            {
                targetEmemy = _enemys[0];
            }

            float maxDistance = _maxDistance * _maxDistance;

            foreach (GameObject enemy in _enemys)
            {
                // �����ƓG�̊Ԃ̋���
                // Distance()����SqrMagnitude()�̕����������ǂ��A���x���ǂ�
                float targetDistance = (enemy.transform.position - this.transform.position).sqrMagnitude;

                // maxDistance�̕���������������X���[
                if (maxDistance <= targetDistance)
                    continue;

                // ������maxDistance�ȉ���������A�X�V����
                maxDistance = targetDistance;
                targetEmemy = enemy;

                _enemyDistance = targetEmemy.transform.position;
            }
            print($"{targetEmemy}�Ǝ����Ƃ̎c�苗����{maxDistance / maxDistance}m�ł�");

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
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(this.transform.position, _maxDistance);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(this.transform.position, _enemyDistance);
    }

    #endregion
}
