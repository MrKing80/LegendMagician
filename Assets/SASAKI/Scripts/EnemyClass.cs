using UnityEngine;
/// <summary>
/// 敵のクラス
/// 作成者：佐々木
/// </summary>
public class EnemyClass : BossEnemyClass
{
    public EnemyClass(string enemyName, int hp, float attackPower, float attackSpeed, float moveSpeed)
        :base(enemyName,hp,attackPower,attackSpeed,moveSpeed)
    {
        //ここに敵の初期化処理を書く
    }

    public override bool IsAlive()
    {
        return _isAlive;
    }
}
