using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "Scriptable Objects/Enemy_DataBase")]
public class EnemyData : ScriptableObject
{
    [Header("敵のステータス")]

    [SerializeField, Header("敵のID")] private int _enemyID = 0;
    [SerializeField, Header("名前")] private string _enemyName = "";
    [SerializeField, Header("ヒットポイント")] private int _enemyHp = 0;
    [SerializeField, Header("攻撃力")] private float _attackPower = 0;
    [SerializeField, Header("攻撃速度")] private float _attackSpeed = 0;
    [SerializeField, Header("移動速度")] private float _moveSpeed = 0;

    // ゲッターで変数を外部に公開することで、他スクリプトから読み取り専用でアクセスできるようにする
    public int ID { get { return _enemyID; } } // 敵IDを取得

    public string Name { get { return _enemyName; } } // 名前を取得

    public int HP { get { return _enemyHp; } } // HPを取得

    public float AttackPower { get { return _attackPower; } } // 攻撃力を取得

    public float AttackSpeed { get { return _attackSpeed; } } // 攻撃速度を取得

    public float MoveSpeed { get { return _moveSpeed; } } // 移動速度を取得
}
