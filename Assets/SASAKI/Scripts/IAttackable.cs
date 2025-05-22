using UnityEngine;

/// <summary>
/// 攻撃処理を行うインターフェース
/// 作成者：佐々木
/// </summary>
public interface IAttackable
{
    /// <summary>
    /// プレイヤーから敵への攻撃を行うメソッド
    /// </summary>
    /// <param name="user">プレイヤー</param>
    /// <param name="target">敵</param>
    public void Attack(PlayerClass user, BossEnemyClass target);

    /// <summary>
    /// 敵からプレイヤーへ攻撃を行うメソッド
    /// </summary>
    /// <param name="user">敵</param>
    /// <param name="target">プレイヤー</param>
    public void Attack(BossEnemyClass user, PlayerClass target);
}
