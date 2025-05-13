using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemyData
{
    [Header("�G�̃X�e�[�^�X")]
    [SerializeField, Header("���O")] private string _enemyName = "";
    [SerializeField, Header("�q�b�g�|�C���g")] private int _enemyHp = 0;
    [SerializeField, Header("�U����")] private int _attackPower = 0;
    [SerializeField, Header("�U�����x")] private int _attackSpeed = 0;
    [SerializeField, Header("�ړ����x")] private int _moveSpeed = 0;
}