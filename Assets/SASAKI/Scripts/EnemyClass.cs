using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// 敵のクラス
/// 作成者：佐々木
/// </summary>
public class EnemyClass : BaceCharacter
{
    [SerializeField] private EnemyData _enemyData = default;

    private void Start()
    {
        print(_enemyData.HP);
    }

    public override bool IsAlive()
    {
        return _isAlive;
    }
}
