using System;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// �v���C���[�N���X���Ǘ�����N���X
/// ����ҁF�ʈ�
/// </summary>
public  class PlayerController : MonoBehaviour
{
    [SerializeField, Header("�ړ��X�s�[�h")] private float _speed = 0f;
    private Rigidbody _rb = default;
    private PlayerMove _playerMove = default;

    public PlayerController(string attributeName)
    {
    }

    private void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        _playerMove = new PlayerMove(_speed, _rb);
    }

    private void FixedUpdate()
    {
        _playerMove.PlayerMoving();
    }

    private void Update()
    {
        // �v���C���[�̈ړ��Ɋւ�����͏���
        _playerMove.HandleInput();
    }
}
