using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// �{�X�G�̒��S�ƂȂ�N���X
/// �쐬�ҁF���X��
/// </summary>
public class BossEnemyClass : MonoBehaviour
{
    private int _hp = 0;
    private GameObject _player = default;


    /// <summary>
    /// �_���[�W���󂯂鏈��
    /// </summary>
    /// <param name="damage">�󂯂�_���[�W��</param>
    /// <returns>�_���[�W���󂯂����HP</returns>
    public virtual int TakeDamage(int damage)
    {
        _hp -= damage;

        return _hp;
    }

}
