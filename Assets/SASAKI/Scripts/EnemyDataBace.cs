using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵の情報を保持するデータベースのスクリプタブルオブジェクト
/// </summary>
[CreateAssetMenu(menuName = "Enemy_DataBase")]
public class EnemyDataBase : ScriptableObject
{
    public List<EnemyData> _enemyDatas = new List<EnemyData>();     //敵の情報を格納するリスト
}
