/// <summary>
/// 炎属性の攻撃クラス
/// 作成者：佐々木
/// </summary>
public class FireAttack : BaceAttribute
{

    public FireAttack(string attributeName):base(attributeName)
    {
        //ここにこのスクリプトの初期化処理を書こう
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : 炎上ダメージの処理を書く
        //TODO : 着弾したところの地面を燃やすの処理を書く
    }
}
