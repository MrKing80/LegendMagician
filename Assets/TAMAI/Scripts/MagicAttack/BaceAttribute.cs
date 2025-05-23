using UnityEngine;

/// <summary>
/// 属性のベースクラス
/// 作成者:佐々木
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
    /// 属性が持つ特性の処理を行うメソッド
    /// TODO : 継承先で属性が持つ特性の処理を記述してね
    /// </summary>
    protected abstract void AttributeCharacteristics();

}
