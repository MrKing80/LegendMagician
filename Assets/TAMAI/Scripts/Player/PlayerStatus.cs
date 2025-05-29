using System;
using UnityEngine;

/// <summary>
/// プレイヤーのステータスクラス
/// 制作者：玉井
/// </summary>

// Serializableを付けていると、SerializeFieldを使用しInspector上で値を設定できる
[Serializable]
public class PlayerStatus
{
    [SerializeField, Header("名前")] private string _name = "";
    [SerializeField, Header("体力")] private int _hp = 0;
    [SerializeField, Header("攻撃力")] private float _attackPower = 0f;
    [SerializeField, Header("攻撃スピード")] private float _attackSpeed = 0f;
    [SerializeField, Header("移動スピード")] private float _moveSpeed = 0f;

    // ラムダ式でプロパティを設定
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int HP
    {
        get => _hp;
        set => _hp = value;
    }

    public float AttackPower
    {
        get => _attackPower;
        set => _attackPower = value;
    }

    public float AttackSpeed
    {
        get => _attackSpeed;
        set => _attackSpeed = value;
    }

    public float MoveSpeed
    {
        get => _moveSpeed;
        set => _moveSpeed = value;
    }
}
