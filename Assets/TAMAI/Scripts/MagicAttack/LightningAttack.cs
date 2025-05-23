using UnityEngine;

/// <summary>
/// 雷属性の攻撃クラス
/// 作成者：佐々木
/// </summary>
public class LightningAttack : BaceAttribute
{
    private string _name = "";

    public LightningAttack(string attributeName) : base(attributeName)
    {
        //ここにこのスクリプトの初期化処理を書こう
        _name = attributeName;
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : スタンの処理を書く
        //TODO : 周囲に感電する処理を書く
    }
}
