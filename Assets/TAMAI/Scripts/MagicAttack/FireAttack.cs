using UnityEngine;
using System;

public class FireAttack : BaceAttribute
{
    public FireAttack(int a):base(a)
    {
        print($"{AttributeName()}�U�����擾�����I�v���C���[��{AttributeName()}�U�����̍U���͂�{MagicAttackPower()}���I");
        print("�X�e�[�W���R�����I");
    }

    protected override string AttributeName()
    {
        return "��";
    }

    protected override float MagicAttackPower()
    {
        return 10f;
    }

}
