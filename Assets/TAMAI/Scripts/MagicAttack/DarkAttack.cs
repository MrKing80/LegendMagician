using UnityEngine;

/// <summary>
/// �ő����̍U���N���X
/// �쐬�ҁF���X��
/// </summary>
public class DarkAttack : BaceAttribute
{
    private string _name = "";

    public DarkAttack(string attributeName) : base(attributeName)
    {
        //�����ɂ��̃X�N���v�g�̏�����������������
        _name = attributeName;
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : ���͂������񂹂鏈��������
        //TODO : HP���z�����鏈��������
    }
}
