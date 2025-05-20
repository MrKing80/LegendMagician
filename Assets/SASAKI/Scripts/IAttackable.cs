using UnityEngine;

/// <summary>
/// �U���������s���C���^�[�t�F�[�X
/// �쐬�ҁF���X��
/// </summary>
public interface IAttackable
{
    /// <summary>
    /// �U�����s�����\�b�h
    /// </summary>
    /// <param name="target">�U���̑Ώێ�</param>
    /// <param name="user">�U���̍s����</param>
    public virtual void Attack(BaceCharacter target, BaceCharacter user)
    {
        target.TakeDamage((int)user.AttackPower);
    }
}
