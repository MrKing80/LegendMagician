using UnityEngine;

/// <summary>
/// �{�X�G�̃N���X
/// </summary>
public class BossEnemyClass : BaceCharacter
{
    public BossEnemyClass(string bossName,int hp, float attackPower, float attackSpeed,float moveSpeed)
        : base(bossName,hp,attackPower,attackSpeed,moveSpeed)
    {
        //�����Ƀ{�X�G�̏���������������
    }

    public override bool IsAlive()
    {
        return _isAlive;
    }
}
