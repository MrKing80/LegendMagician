using UnityEngine;

/// <summary>
/// �G�̈ړ��������Ǘ�����N���X
/// �쐬�ҁF���X��
/// </summary>
public class EnemyMove
{
    private GameObject _player = default;
    private float _moveSpeed = 0;

    public EnemyMove(float moveSpeed, GameObject player)
    {
        _moveSpeed = moveSpeed;
    }

    /// <summary>
    /// �G�̈ړ�����
    /// </summary>
    public void EnemyMoving()
    {
        //�����Ƀv���C���[�̈ʒu����Ɍ��Ēǂ������鏈������������
    }
}
