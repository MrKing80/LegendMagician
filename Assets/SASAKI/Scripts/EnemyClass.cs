using UnityEngine;

/// <summary>
/// �G�̃N���X
/// �쐬�ҁF���X��
/// </summary>
public class EnemyClass : BaceCharacter
{
    [SerializeField] private EnemyData _enemyData = default;


    public override bool IsAlive()
    {
        return _isAlive;
    }
}
