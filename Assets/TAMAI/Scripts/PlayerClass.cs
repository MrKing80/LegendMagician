using System;
using UnityEngine;

/// <summary>
/// プレイヤークラスを管理するクラス
/// 制作者：玉井
/// </summary>
public  class PlayerClass : BaceCharacter
{
    public PlayerClass(string playerName,int hp, float attackPower, float attackSpeed, float moveSpeed)
        :base(playerName, hp, attackPower, attackSpeed, moveSpeed)
    {
        //ここにプレイヤーの初期化を書こう
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
