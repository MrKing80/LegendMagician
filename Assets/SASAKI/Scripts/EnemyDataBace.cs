using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �G�̏���ێ�����f�[�^�x�[�X�̃X�N���v�^�u���I�u�W�F�N�g
/// </summary>
[CreateAssetMenu(menuName = "Enemy_DataBase")]
public class EnemyDataBase : ScriptableObject
{
    public List<EnemyData> _enemyDatas = new List<EnemyData>();     //�G�̏����i�[���郊�X�g
}
