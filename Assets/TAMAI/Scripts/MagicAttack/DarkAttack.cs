using UnityEngine;

/// <summary>
/// 闇属性の攻撃クラス
/// 作成者：佐々木
/// </summary>
[CreateAssetMenu(menuName = "Skills/DarkAttack")]
public class DarkAttack : BaseAttribute
{

    public DarkAttack()
    {
        //ここにこのスクリプトの初期化処理を書こう
    }

    public override void AttributeCharacteristics(GameObject enemy)
    {
        //TODO : 周囲を引き寄せる処理を書く
        //TODO : HPを吸収する処理を書く
    }
}
