using UnityEngine;

/// <summary>
/// ボス敵のクラス
/// </summary>
public class BossEnemyClass : BaceCharacter
{
    public BossEnemyClass(string bossName,int hp, float attackPower, float attackSpeed,float moveSpeed)
        : base(bossName,hp,attackPower,attackSpeed,moveSpeed)
    {
        //ここにボス敵の初期化処理を書く
    }

    public override bool IsAlive()
    {
        return _isAlive;
    }
}
