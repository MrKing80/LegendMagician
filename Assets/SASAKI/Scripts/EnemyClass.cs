using UnityEngine;
/// <summary>
/// 敵の中心となるクラス
/// 作成者：佐々木
/// </summary>
public class EnemyClass : BossEnemyClass
{
    //スクリプタブルオブジェクトからステータスを持ってきたい
    [SerializeField] private EnemyDataBase _enemyDataBase = default;
    [SerializeField, Range(0, 5)] private int _enemyID = 0;
    private EnemyData _enemyData = default;
    private EnemyMove _enemyMove = default;
    private GameObject _player = default;

    private int _maxHp = 0;
    private int _currentHp = 0;

    private bool _isAlive = true;

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
    public override void TakeDamage(int damage)
    {
        //ここにダメージを受ける処理
        _currentHp -= damage;
    }

    /// <summary>
    /// 攻撃を行うメソッド
    /// </summary>
    /// <param name="target">攻撃対象(プレイヤー)</param>
    public override void Attack(IDamageable target)
    {
        //ここに基本的な攻撃の処理
    }

    public override bool IsAlive()
    {
        return _isAlive;
    }

}
