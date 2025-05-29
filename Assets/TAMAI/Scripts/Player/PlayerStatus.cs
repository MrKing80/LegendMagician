using System;
using UnityEngine;

/// <summary>
/// �v���C���[�̃X�e�[�^�X�N���X
/// ����ҁF�ʈ�
/// </summary>

// Serializable��t���Ă���ƁASerializeField���g�p��Inspector��Œl��ݒ�ł���
[Serializable]
public class PlayerStatus
{
    [SerializeField, Header("���O")] private string _name = "";
    [SerializeField, Header("�̗�")] private int _hp = 0;
    [SerializeField, Header("�U����")] private float _attackPower = 0f;
    [SerializeField, Header("�U���X�s�[�h")] private float _attackSpeed = 0f;
    [SerializeField, Header("�ړ��X�s�[�h")] private float _moveSpeed = 0f;

    // �����_���Ńv���p�e�B��ݒ�
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int HP
    {
        get => _hp;
        set => _hp = value;
    }

    public float AttackPower
    {
        get => _attackPower;
        set => _attackPower = value;
    }

    public float AttackSpeed
    {
        get => _attackSpeed;
        set => _attackSpeed = value;
    }

    public float MoveSpeed
    {
        get => _moveSpeed;
        set => _moveSpeed = value;
    }
}
