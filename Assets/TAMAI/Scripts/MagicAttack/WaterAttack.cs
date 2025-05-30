using UnityEngine;

/// <summary>
/// 水属性の攻撃クラス
/// 作成者：佐々木
/// </summary>
[CreateAssetMenu(menuName = "Skills/WaterAttack")]
public class WaterAttack : BaseAttribute
{

    public WaterAttack()
    {
        //ここにこのスクリプトの初期化処理を書こう
    }

    public override void AttributeCharacteristics(GameObject enemy)
    {
        //TODO : 移動速度低下の処理を書く
        //TODO : 着弾したところの地面をに水溜まりを生成する処理を書く
    }
}
