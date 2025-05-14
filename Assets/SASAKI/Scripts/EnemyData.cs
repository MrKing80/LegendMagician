using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "Enemy_DataBase")]
public class EnemyData : ScriptableObject
{
    [Header("敵のステータス")]
    [SerializeField, Header("名前")] private string _enemyName = "";
    [SerializeField, Header("ヒットポイント")] private int _enemyHp = 0;
    [SerializeField, Header("攻撃力")] private int _attackPower = 0;
    [SerializeField, Header("攻撃速度")] private int _attackSpeed = 0;
    [SerializeField, Header("移動速度")] private int _moveSpeed = 0;

    //各変数はゲッターで取得できるようにしよう。
    public int HP { get { return _enemyHp; } }
}