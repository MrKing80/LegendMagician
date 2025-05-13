using UnityEngine;

/// <summary>
/// 制作者：玉井
/// 
/// プレイヤーの動作を管理するクラス。
/// </summary>

public class PlayerMove : MonoBehaviour
{
    [SerializeField, Header("移動スピード")] private float _speed = 0f;
    private Vector3 _position = Vector3.zero;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // 現在の位置を取得し、物理的に一定速度で移動。
        _rb.MovePosition(_rb.position + _position * _speed * Time.fixedDeltaTime);
    }

    private void Update()
    {
        // プレイヤーの移動に関する入力処理
        HandleInput();
    }

    /// <summary>
    /// プレイヤーの移動入力を処理
    /// </summary>
    private void HandleInput()
    {
        // 入力処理をUpdateで行い、物理演算と分離し最適化
        _position.x = Input.GetAxisRaw("Horizontal");
        _position.z = Input.GetAxisRaw("Vertical");

        // 移動方向を正規化し、斜め移動を一定に
        _position = _position.normalized;
    }
}
