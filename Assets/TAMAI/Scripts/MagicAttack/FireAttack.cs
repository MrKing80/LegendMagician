using UnityEngine;
using System;

public class FireAttack : PlayerClass
{
    public FireAttack() : base()
    {
        print("�X�e�[�W���R�����I");
    }

    protected override string MagicName()
    {
        return "��";
    }

    protected override float MagicAttackPower()
    {
        return 10f;
    }

}
