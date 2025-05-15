using System;
using UnityEngine;

/// <summary>
/// �v���C���[�N���X���Ǘ�����N���X
/// ����ҁF�ʈ�
/// </summary>
public class PlayerClass : BaceCharacter
{
    private string _playerName = "";
    private int _hp = 0;
    private float _attackPower = 0f;
    private float _attackSpeed = 0f;
    private float _moveSpeed = 0f;

    // �q�N���X�Ōp������
    protected abstract string MagicName();
    protected abstract float MagicAttackPower();


    public string Attack()
    {
        return $"{MagicName()}�U�����擾�����I�v���C���[��{MagicName()}�U�����̍U���͂�{MagicAttackPower()}���I";
    }

    /// <summary>
    ///  ��������p���\�b�h
    /// </summary>
    /// <returns></returns>
    public override bool IsAlive()
    {
        return _isAlive;
    }
}
