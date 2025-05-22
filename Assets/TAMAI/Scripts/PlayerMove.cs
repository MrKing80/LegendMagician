using UnityEngine;

/// <summary>
/// �v���C���[�̓�����Ǘ�����N���X�B
/// ����ҁF�ʈ�
/// </summary>

public class PlayerMove
{
    [SerializeField, Header("�ړ��X�s�[�h")] private float _speed = 0f;
    private Vector3 _position = Vector3.zero;
    private Rigidbody _rb;

    public PlayerMove(Rigidbody rb)
    {
        // ����������
        _rb = rb;
    }

    public void PlayerMoving()
    {
        // ���݂̈ʒu���擾���A�����I�Ɉ�葬�x�ňړ��B
        _rb.MovePosition(_rb.position + _speed * Time.fixedDeltaTime * _position);
    }

    /// <summary>
    /// �v���C���[�̈ړ����͂�����
    /// </summary>
    public void HandleInput()
    {
        // ���͏�����Update�ōs���A�������Z�ƕ������œK��
        _position.x = Input.GetAxisRaw("Horizontal");
        _position.z = Input.GetAxisRaw("Vertical");

        // �ړ������𐳋K�����A�΂߈ړ�������
        _position = _position.normalized;
    }
}
