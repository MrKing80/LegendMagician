using System;
using UnityEngine;

/// <summary>
/// プレイヤークラスを管理するクラス
/// 制作者：玉井
/// </summary>
public class PlayerClass : BaceCharacter
{
    private string _playerName = "";
    private int _hp = 0;
    private float _attackPower = 0f;
    private float _attackSpeed = 0f;
    private float _moveSpeed = 0f;

    // 子クラスで継承する
    protected abstract string MagicName();
    protected abstract float MagicAttackPower();


    public string Attack()
    {
        return $"{MagicName()}攻撃を取得した！プレイヤーは{MagicName()}攻撃をの攻撃力は{MagicAttackPower()}だ！";
    }

    /// <summary>
    ///  生存判定用メソッド
    /// </summary>
    /// <returns></returns>
    public override bool IsAlive()
    {
        return _isAlive;
    }
}
