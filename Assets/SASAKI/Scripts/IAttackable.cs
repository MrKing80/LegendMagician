using UnityEngine;

/// <summary>
/// �U���������s���C���^�[�t�F�[�X
/// �쐬�ҁF���X��
/// </summary>
public interface IAttackable
{
    /// <summary>
    /// �v���C���[����G�ւ̍U�����s�����\�b�h
    /// </summary>
    /// <param name="user">�v���C���[</param>
    /// <param name="target">�G</param>
    public void Attack(PlayerClass user, BossEnemyClass target);

    /// <summary>
    /// �G����v���C���[�֍U�����s�����\�b�h
    /// </summary>
    /// <param name="user">�G</param>
    /// <param name="target">�v���C���[</param>
    public void Attack(BossEnemyClass user, PlayerClass target);
}
