using UnityEngine;

/// <summary>
/// �X�L���f�[�^�N���X
/// ����ҁF�ʈ�
/// </summary>
[CreateAssetMenu]
public class SkillData : ScriptableObject
{
    [SerializeField, Header("�A�C�R��")] private Sprite _icon = default;
    [SerializeField, Header("ID"), Range(0, 5)] private int _id = 0;
    [SerializeField, Header("���O")] private string _name = "";

    public Sprite Icon => _icon;
    public int Id => _id;
    public string Name => _name;
}
