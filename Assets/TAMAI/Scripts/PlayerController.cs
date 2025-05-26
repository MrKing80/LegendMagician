using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

/// <summary>
/// プレイヤークラスを管理するクラス
/// 制作者：玉井
/// </summary>
public class PlayerController : MonoBehaviour, IAttackable
{
    [SerializeField, Header("ステータス")]
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

        // プレイヤーのステータスを取得
        _name = _playerStatus.Name;
        _maxHp = _playerStatus.HP;
        _currentHp = _maxHp;
        _attackPower = _playerStatus.AttackPower;
        _attackSpeed = _playerStatus.AttackSpeed;
        _moveSpeed = _playerStatus.MoveSpeed;

        // 移動処理
        _playerMove = new PlayerMove(_moveSpeed, _rb);
        
        _baceAttribute = new FireAttack("炎");

        List<GameObject> enemys = _enemyManager.GetEnemies();
        print($"{enemys.Count}");
    }

    private void FixedUpdate()
    {
        _playerMove.PlayerMoving();
    }

    private void Update()
    {
        // プレイヤーの移動に関する入力処理
        _playerMove.HandleInput();

        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log($"{_baceAttribute.AttributeName}魔法発動！");
    }

    public void Attack(IDamageable target)
    {
        // 殴る処理
        //一番近い敵を探索
        //一番近い敵に一定間隔で攻撃→コルーチン

    }
}
