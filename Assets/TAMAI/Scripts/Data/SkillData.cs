using UnityEngine;

/// <summary>
/// スキルデータクラス
/// 制作者：玉井
/// </summary>
[CreateAssetMenu]
public class SkillData : ScriptableObject
{
    [SerializeField, Header("アイコン")] private Sprite _icon = default;
    [SerializeField, Header("ID"), Range(0, 5)] private int _id = 0;
    [SerializeField, Header("名前")] private string _name = "";

    public Sprite Icon => _icon;
    public int Id => _id;
    public string Name => _name;
}
