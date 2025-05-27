using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ステージ上にある敵を参照
/// </summary>
public class EnemyManager : MonoBehaviour
{
    private List<GameObject> _enemies = new List<GameObject>(); // 敵オブジェクトのリスト
    private GameObject[] _enemyObjects = default;               // タグで取得した敵オブジェクト配列
    private float _waitSecond = 1f;                             // 一定時間待機するための秒数

    private void Awake()
    {
        _enemyObjects = GameObject.FindGameObjectsWithTag("Enemy"); // シーン内の "Enemy" タグのオブジェクトをすべて取得
    }

    private IEnumerator GetActiveEnemies()
    {
        yield return new WaitForSeconds(_waitSecond); // 指定時間待機
        _enemyObjects = GameObject.FindGameObjectsWithTag("Enemy"); // 再取得して最新状態に更新
    }

    public List<GameObject> GetEnemies()
    {
        // 敵配列からリストに追加（逆順で追加）
        for (int i = _enemyObjects.Length - 1; i >= 0; i--)
        {
            _enemies.Add(_enemyObjects[i]);
        }

        return _enemies; // 敵オブジェクトのリストを返す
    }
}
