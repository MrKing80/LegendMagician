using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// �G�̃N���X
/// �쐬�ҁF���X��
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
