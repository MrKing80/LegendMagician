using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "Enemy_DataBase")]
public class EnemyData : ScriptableObject
{
    [Header("�G�̃X�e�[�^�X")]
    [SerializeField, Header("���O")] private string _enemyName = "";
    [SerializeField, Header("�q�b�g�|�C���g")] private int _enemyHp = 0;
    [SerializeField, Header("�U����")] private int _attackPower = 0;
    [SerializeField, Header("�U�����x")] private int _attackSpeed = 0;
    [SerializeField, Header("�ړ����x")] private int _moveSpeed = 0;

    //�e�ϐ��̓Q�b�^�[�Ŏ擾�ł���悤�ɂ��悤�B
    public int HP { get { return _enemyHp; } }
}