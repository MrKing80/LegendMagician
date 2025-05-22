using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// ボス敵の中心となるクラス
/// 作成者：佐々木
/// </summary>
public class BossEnemyClass : MonoBehaviour
{
    private int _hp = 0;
    private GameObject _player = default;


    /// <summary>
    /// ダメージを受ける処理
    /// </summary>
    /// <param name="damage">受けるダメージ量</param>
    /// <returns>ダメージを受けた後のHP</returns>
    public virtual int TakeDamage(int damage)
    {
        _hp -= damage;

        return _hp;
    }

}
