using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �X�e�[�W��ɂ���G���Q��
/// </summary>
public class EnemyManager : MonoBehaviour
{
    private List<GameObject> _enemies = new List<GameObject>(); // �G�I�u�W�F�N�g�̃��X�g
    private GameObject[] _enemyObjects = default;               // �^�O�Ŏ擾�����G�I�u�W�F�N�g�z��
    private float _waitSecond = 1f;                             // ��莞�ԑҋ@���邽�߂̕b��

    private void Awake()
    {
        _enemyObjects = GameObject.FindGameObjectsWithTag("Enemy"); // �V�[������ "Enemy" �^�O�̃I�u�W�F�N�g�����ׂĎ擾
    }

    private IEnumerator GetActiveEnemies()
    {
        yield return new WaitForSeconds(_waitSecond); // �w�莞�ԑҋ@
        _enemyObjects = GameObject.FindGameObjectsWithTag("Enemy"); // �Ď擾���čŐV��ԂɍX�V
    }

    public List<GameObject> GetEnemies()
    {
        // �G�z�񂩂烊�X�g�ɒǉ��i�t���Œǉ��j
        for (int i = _enemyObjects.Length - 1; i >= 0; i--)
        {
            _enemies.Add(_enemyObjects[i]);
        }

        return _enemies; // �G�I�u�W�F�N�g�̃��X�g��Ԃ�
    }
}
