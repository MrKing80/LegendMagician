using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// ボス敵の中心となるクラス
/// 作成者：佐々木
/// </summary>
public class BossEnemyClass : MonoBehaviour, IAttackable, IDamageable
{
    //スクリプタブルオブジェクトからステータスを持ってきたい
    [SerializeField] protected EnemyDataBase _enemyDataBase = default;
    [SerializeField, Range(0, 5)] protected int _enemyID = 0;
    protected EnemyData _enemyData = default;
    protected EnemyMove _enemyMove = default;
    protected GameObject _player = default;

    protected int _maxHp = 0;
    protected int _currentHp = 0;

    protected bool _isAlive = true;

    /// <summary>
    /// 主に初期化処理、インスタンス生成をするメソッド
    /// </summary>
    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

        _enemyData = _enemyDataBase._enemyDatas[_enemyID];

        _maxHp = _currentHp = _enemyData.HP;

        _enemyMove = new EnemyMove(_enemyData.MoveSpeed, _player);
    }

    /// <summary>
    /// ダメージを受ける処理
    /// </summary>
    /// <param name="damage">受けるダメージ量</param>
    public virtual void TakeDamage(int damage)
    {
        //ここにダメージを受ける処理
        _currentHp -= damage;
    }

    /// <summary>
    /// 攻撃を行うメソッド
    /// </summary>
    /// <param name="target">攻撃対象(プレイヤー)</param>
    public virtual void Attack(IDamageable target)
    {
        //ここに基本的な攻撃の処理
    }

    /// <summary>
    /// ボス固有の行動をするメソッド
    /// </summary>
    private void UniqueActions()
    {
        //ここにボスのみがとる行動の処理を書く
    }

    /// <summary>
    /// 敵が生存しているかの判定を行うメソッド
    /// </summary>
    /// <returns>true：生存してる false：死んでいる</returns>
    public virtual bool IsAlive()
    {
        return _isAlive;
    }
}
