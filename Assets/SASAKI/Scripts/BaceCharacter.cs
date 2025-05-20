using UnityEngine;

/// <summary>
/// �L�����N�^�[�̃x�[�X�N���X
/// �쐬�ҁF���X��
/// </summary>
public abstract class BaceCharacter : MonoBehaviour
{
    protected string _characterName = "";
    protected int _hp = 0;
    protected float _attackPower = 0f;
    protected float _attackSpeed = 0f;
    protected float _moveSpeed = 0f;
    private int _characterId = 0;
    protected bool _isAlive = true;
    // TODO : ��ő����̏����i�[����ϐ�����������

    public BaceCharacter(string playerName, int hp, float attackPower, float attackSpeed, float moveSpeed)
    {
        _characterName = playerName;
        _hp = hp;
        _attackPower = attackPower;
        _attackSpeed = attackSpeed;
        _moveSpeed = moveSpeed;
    }

    /// <summary>
    /// ��������p���\�b�h
    /// �� abstract�͌p���������΂��̃��\�b�h���g���Ă˂Ƃ����Ӗ��ɂȂ��
    /// </summary>
    /// <returns>true�F�����Ă� false�F����ł�</returns>
    public abstract bool IsAlive();
}
