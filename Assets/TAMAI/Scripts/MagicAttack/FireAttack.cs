using UnityEngine;
using System;

public class FireAttack : BaceAttribute
{
    private string _attributeName = "";

    public FireAttack(string attributeName)
    {
        _attributeName = attributeName;
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : ����_���[�W�̏���������
        //TODO : ���e�����Ƃ���̒n�ʂ�R�₷�̏���������.
    }
}
