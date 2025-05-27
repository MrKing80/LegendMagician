using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤークラスを管理するクラス
/// 制作者：玉井
/// </summary>
public class PlayerController : MonoBehaviour, IAttackable
{
    [SerializeField, Space]
    private EnemyManager _enemyManager = default;

    [SerializeField, Header("ステータス")]
    private PlayerStatus _playerStatus = default;

    [SerializeField, Space]
    private bool _isAttack = true;

    [SerializeField, Space]
    // 観測距離限界を保持
    private float _maxDistance = 0f;

    [SerializeField, Header("一番近い敵を更新する際の待機時間"), Space]
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

        // エネミーリストを取得
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
        // プレイヤーの移動に関する入力処理
        _playerMove.HandleInput();
    }

    /// <summary>
    /// 自動攻撃
    /// </summary>
    /// <param name="target">一番近い敵</param>
    public void Attack(IDamageable target)
    {
        // 殴る処理
        //一番近い敵を探索
        //一番近い敵に一定間隔で攻撃→コルーチン

        Debug.Log($"{_baceAttribute.AttributeName}魔法発動！");

    }

    #region コルーチン

    /// <summary>
    /// 一番近い敵を一定間隔で探索
    /// </summary>
    private IEnumerator NearestEnemy()
    {
        while (_isAttack == true)
        {
            // 敵がいない場合はスルー
            if (_enemys.Count == 0)
                continue;
                
            // 一番近い敵
            GameObject targetEmemy = default;

            // 敵が一体だけだったら
            if (_enemys.Count == 1)
            {
                targetEmemy = _enemys[0];
            }

            float maxDistance = _maxDistance * _maxDistance;

            foreach (GameObject enemy in _enemys)
            {
                // 自分と敵の間の距離
                // Distance()よりもSqrMagnitude()の方が効率が良く、精度が良い
                float targetDistance = (enemy.transform.position - this.transform.position).sqrMagnitude;

                // maxDistanceの方が小さかったらスルー
                if (maxDistance <= targetDistance)
                    continue;

                // 距離がmaxDistance以下だったら、更新する
                maxDistance = targetDistance;
                targetEmemy = enemy;

                _enemyDistance = targetEmemy.transform.position;
            }
            print($"{targetEmemy}と自分との残り距離は{maxDistance / maxDistance}mです");

            IDamageable attackTarget = targetEmemy.GetComponent<IDamageable>();
            Attack(attackTarget);

            // 指定時間待機 
            yield return new WaitForSeconds(_wait);
            print($"{_wait}秒毎に更新！");
        }
    }
    #endregion

    #region _maxDistanceをエディタ上で見れるよう描画処理

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(this.transform.position, _maxDistance);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(this.transform.position, _enemyDistance);
    }

    #endregion
}
