using System;
using UnityEngine;

/// <summary>
/// �v���C���[�N���X���Ǘ�����N���X
/// ����ҁF�ʈ�
/// </summary>
public  class PlayerClass : BaceCharacter
{
    private string _playerName = "";
    private int _hp = 0;
    private float _attackPower = 0f;
    private float _attackSpeed = 0f;
    private float _moveSpeed = 0f;

    private void Start()
    {
        print("�����@���Ăяo���܂�");
        PlayerClass playerClass = new PlayerClass();
        FireAttack fireAttack = new FireAttack(2);
    }

    //public string Attack()
    //{
    //    
    //}

    /// <summary>
    ///  ��������p���\�b�h
    /// </summary>
    /// <returns></returns>
    public override bool IsAlive()
    {
        return _isAlive;
    }
}
