using UnityEngine;

/// <summary>
/// 属性のベースクラス
/// 作成者:佐々木
/// </summary>
[System.Serializable]
public class BaseAttribute : ScriptableObject
{
    [SerializeField, Header("アイコン")] private Sprite _icon = default;
    [SerializeField, Header("属性のスクリプト")] private BaseAttribute _attribute = default;
    [SerializeField, Header("ID"), Range(0, 5)] private int _id = 0;
    [SerializeField, Header("名前")] private string _name = "";

    public Sprite Icon => _icon;
    public BaseAttribute Attribute => _attribute;
    public int Id => _id;
    public string Name => _name;

    public BaseAttribute()
    {

    }

    /// <summary>
    /// 属性が持つ特性の処理を行うメソッド
    /// TODO : 継承先で属性が持つ特性の処理を記述してね
    /// </summary>
    public virtual void AttributeCharacteristics()
    {

    }

}
