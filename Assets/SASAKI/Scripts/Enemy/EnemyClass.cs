using UnityEngine;
/// <summary>
/// 敵の中心となるクラス
/// 作成者：佐々木
/// </summary>
public class EnemyClass : BossEnemyClass
{

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
        print($"{this.gameObject}の残りHPは{_currentHp}です。");
    }

    /// <summary>
    /// 攻撃を行うメソッド
    /// </summary>
    /// <param name="target">攻撃対象(プレイヤー)</param>
    public override void Attack(IDamageable target)
    {
        //ここに基本的な攻撃の処理
    }

    /// <summary>
    /// 敵が生存しているかの判定を行うメソッド
    /// </summary>
    /// <returns>true：生存してる false：死んでいる</returns>
    public override bool IsAlive()
    {
        return _isAlive;
    }

}
