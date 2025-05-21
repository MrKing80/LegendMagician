using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "Scriptable Objects/Enemy_DataBase")]
public class EnemyData : ScriptableObject
{
    [Header("�G�̃X�e�[�^�X")]

    [SerializeField, Header("�G��ID")] private int _enemyID = 0;
    [SerializeField, Header("���O")] private string _enemyName = "";
    [SerializeField, Header("�q�b�g�|�C���g")] private int _enemyHp = 0;
    [SerializeField, Header("�U����")] private float _attackPower = 0;
    [SerializeField, Header("�U�����x")] private float _attackSpeed = 0;
    [SerializeField, Header("�ړ����x")] private float _moveSpeed = 0;

    // �Q�b�^�[�ŕϐ����O���Ɍ��J���邱�ƂŁA���X�N���v�g����ǂݎ���p�ŃA�N�Z�X�ł���悤�ɂ���
    public int ID { get { return _enemyID; } } // �GID���擾

    public string Name { get { return _enemyName; } } // ���O���擾

    public int HP { get { return _enemyHp; } } // HP���擾

    public float AttackPower { get { return _attackPower; } } // �U���͂��擾

    public float AttackSpeed { get { return _attackSpeed; } } // �U�����x���擾

    public float MoveSpeed { get { return _moveSpeed; } } // �ړ����x���擾
}
