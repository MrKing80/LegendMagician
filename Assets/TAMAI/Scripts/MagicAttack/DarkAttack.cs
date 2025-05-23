using UnityEngine;

/// <summary>
/// 闇属性の攻撃クラス
/// 作成者：佐々木
/// </summary>
public class DarkAttack : BaceAttribute
{
    private string _name = "";

    public DarkAttack(string attributeName) : base(attributeName)
    {
        //ここにこのスクリプトの初期化処理を書こう
        _name = attributeName;
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : 周囲を引き寄せる処理を書く
        //TODO : HPを吸収する処理を書く
    }
}
