using UnityEngine;
using System;

public class FireAttack : PlayerClass
{
    public FireAttack() : base()
    {
        print("ステージが燃えた！");
    }

    protected override string MagicName()
    {
        return "炎";
    }

    protected override float MagicAttackPower()
    {
        return 10f;
    }

}
