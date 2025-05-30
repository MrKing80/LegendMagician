using UnityEngine;

/// <summary>
/// �����̃x�[�X�N���X
/// �쐬��:���X��
/// </summary>
[System.Serializable]
public class BaseAttribute : ScriptableObject
{
    [SerializeField, Header("�A�C�R��")] private Sprite _icon = default;
    [SerializeField, Header("�����̃X�N���v�g")] private BaseAttribute _attribute = default;
    [SerializeField, Header("ID"), Range(0, 5)] private int _id = 0;
    [SerializeField, Header("���O")] private string _name = "";

    public Sprite Icon => _icon;
    public BaseAttribute Attribute => _attribute;
    public int Id => _id;
    public string Name => _name;

    public BaseAttribute()
    {

    }

    /// <summary>
    /// �������������̏������s�����\�b�h
    /// TODO : �p����ő������������̏������L�q���Ă�
    /// </summary>
    public virtual void AttributeCharacteristics()
    {

    }

}
