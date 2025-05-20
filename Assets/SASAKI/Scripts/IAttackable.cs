using UnityEngine;

/// <summary>
/// 攻撃処理を行うインターフェース
/// 作成者：佐々木
/// </summary>
public interface IAttackable
{
    /// <summary>
    /// 攻撃を行うメソッド
    /// </summary>
    /// <param name="target">攻撃の対象者</param>
    /// <param name="user">攻撃の行動者</param>
    public virtual void Attack(BaceCharacter target, BaceCharacter user)
    {
        target.TakeDamage((int)user.AttackPower);
    }
}
