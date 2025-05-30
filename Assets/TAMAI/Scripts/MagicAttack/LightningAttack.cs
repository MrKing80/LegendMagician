using UnityEngine;

/// <summary>
/// 雷属性の攻撃クラス
/// 作成者：佐々木
/// </summary>
[CreateAssetMenu(menuName = "Skills/LightningAttack")]
public class LightningAttack : BaseAttribute
{

    public LightningAttack()
    {
        //ここにこのスクリプトの初期化処理を書こう
    }

    public override void AttributeCharacteristics(GameObject enemy)
    {
        //TODO : スタンの処理を書く
        //TODO : 周囲に感電する処理を書く
    }
}
