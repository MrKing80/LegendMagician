using UnityEngine;
/// <summary>
/// �G�̒��S�ƂȂ�N���X
/// �쐬�ҁF���X��
/// </summary>
public class EnemyClass : BossEnemyClass
{

    /// <summary>
    /// �_���[�W���󂯂鏈��
    /// </summary>
    /// <param name="damage">�󂯂�_���[�W��</param>
    public override void TakeDamage(int damage)
    {
        //�����Ƀ_���[�W���󂯂鏈��
        _currentHp -= damage;
    }

    /// <summary>
    /// �U�����s�����\�b�h
    /// </summary>
    /// <param name="target">�U���Ώ�(�v���C���[)</param>
    public override void Attack(IDamageable target)
    {
        //�����Ɋ�{�I�ȍU���̏���
    }

    /// <summary>
    /// �G���������Ă��邩�̔�����s�����\�b�h
    /// </summary>
    /// <returns>true�F�������Ă� false�F����ł���</returns>
    public override bool IsAlive()
    {
        return _isAlive;
    }

}
