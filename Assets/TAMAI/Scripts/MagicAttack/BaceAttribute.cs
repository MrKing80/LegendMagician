using UnityEngine;

/// <summary>
/// �����̃x�[�X�N���X
/// �쐬��:���X��
/// </summary>
public abstract class BaceAttribute
{
    private string _attributeName = "";

    public string AttributeName
    {
        get { return _attributeName; }
    }

    public BaceAttribute(string attributeName)
    {
        _attributeName = attributeName;
    }

    /// <summary>
    /// �������������̏������s�����\�b�h
    /// TODO : �p����ő������������̏������L�q���Ă�
    /// </summary>
    protected abstract void AttributeCharacteristics();

}
