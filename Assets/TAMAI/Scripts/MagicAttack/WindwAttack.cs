using UnityEngine;

/// <summary>
/// �������̍U���N���X
/// �쐬�ҁF���X��
/// </summary>
public class WindwAttack : BaceAttribute
{
    private string _name = "";

    public WindwAttack(string attributeName) : base(attributeName)
    {
        //�����ɂ��̃X�N���v�g�̏�����������������
        _name = attributeName;
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : �m�b�N�o�b�N�̏���������
        //TODO : �h�䖳���̌v�Z�����鏈��������
    }
}
