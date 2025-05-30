using UnityEngine;

/// <summary>
/// 炎属性の攻撃クラス
/// 作成者：佐々木
/// </summary>
[CreateAssetMenu(menuName = "Skills/FireAttack")]
public class FireAttack : BaseAttribute
{
    private const int FIRE_DAMAGE = 3;

    public FireAttack()
    {
        //ここにこのスクリプトの初期化処理を書こう
    }

    public override void AttributeCharacteristics(GameObject enemy)
    {
        //TODO : 炎上ダメージの処理を書く
        ApplyBurnDamage(enemy);
        //TODO : 着弾したところの地面を燃やすの処理を書く
        IgniteGround();
    }

    /// <summary>
    /// 炎上ダメージの処理
    /// 制作者：玉井
    /// </summary>
    private void ApplyBurnDamage(GameObject enemy)
    {
        enemy.GetComponent<BossEnemyClass>().TakeDamage(FIRE_DAMAGE);

        // 状態異常付与
        Debug.Log($"{enemy}を炎上状態にします。{enemy}に{FIRE_DAMAGE}の炎上ダメージ！");
    }

    /// <summary>
    /// 地面を燃やす処理
    /// 制作者：玉井
    /// </summary>
    private void IgniteGround()
    {
        // 炎エフェクトを生成
        //Instantiate();
        Debug.Log($"フィールドを炎上状態にします。");
    }
}
