using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

/// <summary>
/// �v���C���[�N���X���Ǘ�����N���X
/// ����ҁF�ʈ�
/// </summary>
public class PlayerController : MonoBehaviour, IAttackable
{
    [SerializeField, Header("�X�e�[�^�X")]
    private PlayerStatus _playerStatus = default;

    private PlayerMove _playerMove = default;
    private BaceAttribute _baceAttribute = default;
    private EnemyManager _enemyManager = default;

    private Rigidbody _rb = default;

    private string _name = "";

    private int _currentHp = 0;
    private int _maxHp = 0;

    private float _attackPower = 0f;
    private float _attackSpeed = 0f;
    private float _moveSpeed = 0f;

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

        List<GameObject> enemys = _enemyManager.GetEnemies();
        print($"{enemys.Count}");
    }

    private void FixedUpdate()
    {
        _playerMove.PlayerMoving();
    }

    private void Update()
    {
        // �v���C���[�̈ړ��Ɋւ�����͏���
        _playerMove.HandleInput();

        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log($"{_baceAttribute.AttributeName}���@�����I");
    }

    public void Attack(IDamageable target)
    {
        // ���鏈��
        //��ԋ߂��G��T��
        //��ԋ߂��G�Ɉ��Ԋu�ōU�����R���[�`��

    }
}
