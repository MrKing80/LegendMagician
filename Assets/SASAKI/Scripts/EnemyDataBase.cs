using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDataBase", menuName = "Scriptable Objects/EnemyDataBase")]
public class EnemyDataBase : ScriptableObject
{
    public List<EnemyData> _enemyData = new List<EnemyData>();
}
