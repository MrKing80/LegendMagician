using UnityEngine;

/// <summary>
/// �������̍U���N���X
/// �쐬�ҁF���X��
/// </summary>
public class WaterAttack : BaceAttribute
{
    private string _name = "";

    public WaterAttack(string attributeName) : base(attributeName)
    {
        //�����ɂ��̃X�N���v�g�̏�����������������
        _name = attributeName;
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : �ړ����x�ቺ�̏���������
        //TODO : ���e�����Ƃ���̒n�ʂ��ɐ����܂�𐶐����鏈��������
    }
}
