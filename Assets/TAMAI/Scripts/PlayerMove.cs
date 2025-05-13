using UnityEngine;

/// <summary>
/// ����ҁF�ʈ�
/// 
/// �v���C���[�̓�����Ǘ�����N���X�B
/// </summary>

public class PlayerMove : MonoBehaviour
{
    [SerializeField, Header("�ړ��X�s�[�h")] private float _speed = 0f;
    private Vector3 _position = Vector3.zero;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // ���݂̈ʒu���擾���A�����I�Ɉ�葬�x�ňړ��B
        _rb.MovePosition(_rb.position + _position * _speed * Time.fixedDeltaTime);
    }

    private void Update()
    {
        // �v���C���[�̈ړ��Ɋւ�����͏���
        HandleInput();
    }

    /// <summary>
    /// �v���C���[�̈ړ����͂�����
    /// </summary>
    private void HandleInput()
    {
        // ���͏�����Update�ōs���A�������Z�ƕ������œK��
        _position.x = Input.GetAxisRaw("Horizontal");
        _position.z = Input.GetAxisRaw("Vertical");

        // �ړ������𐳋K�����A�΂߈ړ�������
        _position = _position.normalized;
    }
}
