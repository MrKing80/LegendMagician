using System.Net.NetworkInformation;
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
    protected bool _isAlive = true;
    //��ő����̏����i�[����ϐ�����������

    private void Start()
    {
        print("�����@���Ăяo���܂�");
        PlayerClass playerClass = new PlayerClass();
        FireAttack fireAttack = new FireAttack();
    }

    /// <summary>
    /// ��������p���\�b�h
    /// abstract�͌p���������΂��̃��\�b�h���g���Ă˂Ƃ����Ӗ��ɂȂ��
    /// </summary>
    /// <returns>true�F�����Ă� false�F����ł�</returns>
    public abstract bool IsAlive();
}
