using System;
using UnityEngine;

/// <summary>
/// �v���C���[�N���X���Ǘ�����N���X
/// ����ҁF�ʈ�
/// </summary>
public  class PlayerClass : BaceCharacter
{
    public PlayerClass(string playerName,int hp, float attackPower, float attackSpeed, float moveSpeed)
        :base(playerName, hp, attackPower, attackSpeed, moveSpeed)
    {
        //�����Ƀv���C���[�̏�������������
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
