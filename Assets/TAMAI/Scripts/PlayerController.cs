using System;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// プレイヤークラスを管理するクラス
/// 制作者：玉井
/// </summary>
public  class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    private PlayerMove _playerMove = default;

    public PlayerController(string attributeName)
    {
    }

    private void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        _playerMove = new PlayerMove(_rb);

    }

    private void FixedUpdate()
    {
        _playerMove.PlayerMoving();
    }

    private void Update()
    {
        // プレイヤーの移動に関する入力処理
        _playerMove.HandleInput();
    }
}
