using UnityEngine;

/// <summary>
/// プレイヤーの動作を管理するクラス。
/// 制作者：玉井
/// </summary>

public class PlayerMove
{
    [SerializeField, Header("移動スピード")] private float _speed = 0f;
    private Vector3 _position = Vector3.zero;
    private Rigidbody _rb;

    public PlayerMove(Rigidbody rb)
    {
        // 初期化処理
        _rb = rb;
    }

    public void PlayerMoving()
    {
        // 現在の位置を取得し、物理的に一定速度で移動。
        _rb.MovePosition(_rb.position + _speed * Time.fixedDeltaTime * _position);
    }

    /// <summary>
    /// プレイヤーの移動入力を処理
    /// </summary>
    public void HandleInput()
    {
        // 入力処理をUpdateで行い、物理演算と分離し最適化
        _position.x = Input.GetAxisRaw("Horizontal");
        _position.z = Input.GetAxisRaw("Vertical");

        // 移動方向を正規化し、斜め移動を一定に
        _position = _position.normalized;
    }
}
