using UnityEngine;
using System;

public class FireAttack : BaceAttribute
{
    public FireAttack(int a):base(a)
    {
        print($"{AttributeName()}攻撃を取得した！プレイヤーは{AttributeName()}攻撃をの攻撃力は{MagicAttackPower()}だ！");
        print("ステージが燃えた！");
    }

    protected override string AttributeName()
    {
        return "炎";
    }

    protected override float MagicAttackPower()
    {
        return 10f;
    }

}
