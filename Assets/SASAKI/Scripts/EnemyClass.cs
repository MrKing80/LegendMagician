using UnityEngine;
/// <summary>
/// �G�̃N���X
/// �쐬�ҁF���X��
/// </summary>
public class EnemyClass : BaceCharacter
{
    private string _enemyName = "";
    private int _hp = 0;
    private float _attackPower = 0f;
    private float _attackSpeed = 0f;
    private float _moveSpeed = 0f;



    public override bool IsAlive()
    {
        return _isAlive;
    }
}
