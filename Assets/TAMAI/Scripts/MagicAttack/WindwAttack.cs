using UnityEngine;

/// <summary>
/// 風属性の攻撃クラス
/// 作成者：佐々木
/// </summary>
public class WindwAttack : BaceAttribute
{
    private string _name = "";

    public WindwAttack(string attributeName) : base(attributeName)
    {
        //ここにこのスクリプトの初期化処理を書こう
        _name = attributeName;
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : ノックバックの処理を書く
        //TODO : 防御無視の計算をする処理を書く
    }
}
