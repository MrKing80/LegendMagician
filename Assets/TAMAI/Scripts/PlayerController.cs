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
    #region 変数など

    [SerializeField, Space]
    private EnemyManager _enemyManager = default;

    [SerializeField, Header("ステータス")]
    private PlayerStatus _playerStatus = default;

    [SerializeField, Header("攻撃エフェクト"), Space]
    private List<GameObject> _attackEffects = new();

    [SerializeField, Header("攻撃エフェクト"), Range(0, 4)]
    private int _attackIndex = 0;

    [SerializeField, Header("攻撃処理を走らせるか")]
    private bool _isAttack = true;

    [SerializeField, Header("探索距離")]
    private float _maxDistance = 0f;

    [SerializeField, Header("一番近い敵を更新する際の待機時間")]
    private float _wait = 1f;

    private PlayerMove _playerMove = default;
    private BaceAttribute _baceAttribute = default;

    private Rigidbody _rb = default;

    private Vector3 _enemyDistance = Vector3.zero;

    private IReadOnlyList<GameObject> _enemys = default;

    // ステータス
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

        // プレイヤーのステータスを取得
        _name = _playerStatus.Name;
        _maxHp = _playerStatus.HP;
        _currentHp = _maxHp;
        _attackPower = _playerStatus.AttackPower;
        _attackSpeed = _playerStatus.AttackSpeed;
        _moveSpeed = _playerStatus.MoveSpeed;

        // 移動処理取得
        _playerMove = new PlayerMove(_moveSpeed, _rb);

        // 子オブジェクトとして生成
        Instantiate(_attackEffects[_attackIndex], this.transform.position, Quaternion.identity, this.transform);

        _baceAttribute = new FireAttack("炎");

        // エネミーリストを取得
        _enemys = _enemyManager.GetEnemies();

        StartCoroutine(NearestEnemy());

    }

    private void FixedUpdate()
    {
        // 移動処理
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
        // 殴る処理　未
        //一番近い敵を探索 〆
        //一番近い敵に一定間隔で攻撃→コルーチン　できる

        Debug.Log($"{_baceAttribute.AttributeName}魔法発動！");

    }

    public Vector3 GetEnemy()
    {
        return _enemyDistance;
    }

    #region コルーチン

    /// <summary>
    /// 一番近い敵を一定間隔で探索
    /// </summary>
    private IEnumerator NearestEnemy()
    {
        // アタック処理がtrueの場合
        while (_isAttack == true)
        {
            // 敵がいない場合はスルー
            if (_enemys.Count == 0)
                continue;
                
            // 一番近い敵
            GameObject targetEmemy = default;

            // 敵が一体だけだったら、その一体を取得
            if (_enemys.Count == 1)
            {
                targetEmemy = _enemys[0];
            }

            // 探索距離の2乗
            float maxDistance = _maxDistance * _maxDistance;

            foreach (GameObject enemy in _enemys)
            {
                // 自分と敵の間の距離。sqrMagnitudeの処理の都合で2乗されている
                // Distance()よりもSqrMagnitude()の方が効率が良く、精度が良い
                float targetDistance = (enemy.transform.position - this.transform.position).sqrMagnitude;

                // maxDistanceの方が小さかったらスルー
                if (maxDistance <= targetDistance)
                    continue;

                // 距離がmaxDistance以下だったら、更新する
                maxDistance = targetDistance;
                targetEmemy = enemy;

                // 一番近い敵を視覚的にわかりやすくするため記録
                _enemyDistance = targetEmemy.transform.position;
            }
            print($"{targetEmemy}と自分との残り距離は{maxDistance / maxDistance}mです");

            // 一番近い敵のダメージ処理を呼び出し、攻撃する
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
        // マゼンタ色で敵探索範囲を描画
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(this.transform.position, _maxDistance);

        // 青色で一番近い敵と自分の間に線を引く
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(this.transform.position, _enemyDistance);
    }

    #endregion
}
