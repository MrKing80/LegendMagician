/// <summary>
/// �������̍U���N���X
/// �쐬�ҁF���X��
/// </summary>
public class FireAttack : BaceAttribute
{
    private string _name = "";
    public FireAttack(string attributeName):base(attributeName)
    {
        //�����ɂ��̃X�N���v�g�̏�����������������
        _name = attributeName;
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : ����_���[�W�̏���������
        //TODO : ���e�����Ƃ���̒n�ʂ�R�₷�̏���������
    }
}
