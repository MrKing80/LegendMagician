using System;
using UnityEngine;

/// <summary>
/// プレイヤークラスを管理するクラス
/// 制作者：玉井
/// </summary>
public  class PlayerClass : BaceCharacter
{
    private string _playerName = "";
    private int _hp = 0;
    private float _attackPower = 0f;
    private float _attackSpeed = 0f;
    private float _moveSpeed = 0f;

    private void Start()
    {
        print("炎魔法を呼び出します");
        PlayerClass playerClass = new PlayerClass();
        FireAttack fireAttack = new FireAttack(2);
    }

    //public string Attack()
    //{
    //    
    //}

    /// <summary>
    ///  生存判定用メソッド
    /// </summary>
    /// <returns></returns>
    public override bool IsAlive()
    {
        return _isAlive;
    }
}
