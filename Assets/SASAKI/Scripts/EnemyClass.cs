using UnityEngine;
/// <summary>
/// �G�̃N���X
/// �쐬�ҁF���X��
/// </summary>
public class EnemyClass : BossEnemyClass
{
    public EnemyClass(string enemyName, int hp, float attackPower, float attackSpeed, float moveSpeed)
        :base(enemyName,hp,attackPower,attackSpeed,moveSpeed)
    {
        //�����ɓG�̏���������������
    }

    public override bool IsAlive()
    {
        return _isAlive;
    }
}
