using UnityEngine;

/// <summary>
/// 風属性の攻撃クラス
/// 作成者：佐々木
/// </summary>
[CreateAssetMenu(menuName = "Skills/WindwAttack")]
public class WindwAttack : BaseAttribute
{

    public WindwAttack()
    {
        //ここにこのスクリプトの初期化処理を書こう
    }

    public override void AttributeCharacteristics()
    {
        //TODO : ノックバックの処理を書く
        //TODO : 防御無視の計算をする処理を書く
    }
}
