using UnityEngine;
/// <summary>
/// �G�̒��S�ƂȂ�N���X
/// �쐬�ҁF���X��
/// </summary>
public class EnemyClass : BossEnemyClass
{
    //�X�N���v�^�u���I�u�W�F�N�g����X�e�[�^�X�������Ă�����
    [SerializeField] private EnemyDataBase _enemyDataBase = default;
    [SerializeField, Range(0, 5)] private int _enemyID = 0;
    private EnemyData _enemyData = default;
    private EnemyMove _enemyMove = default;
    private GameObject _player = default;

    private int _maxHp = 0;
    private int _currentHp = 0;

    private bool _isAlive = true;

    /// <summary>
    /// ��ɏ����������A�C���X�^���X���������郁�\�b�h
    /// </summary>
    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

        _enemyData = _enemyDataBase._enemyDatas[_enemyID];

        _maxHp = _currentHp = _enemyData.HP;

        _enemyMove = new EnemyMove(_enemyData.MoveSpeed, _player);
    }

    /// <summary>
    /// �_���[�W���󂯂鏈��
    /// </summary>
    /// <param name="damage">�󂯂�_���[�W��</param>
    public override void TakeDamage(int damage)
    {
        //�����Ƀ_���[�W���󂯂鏈��
        _currentHp -= damage;
    }

    /// <summary>
    /// �U�����s�����\�b�h
    /// </summary>
    /// <param name="target">�U���Ώ�(�v���C���[)</param>
    public override void Attack(IDamageable target)
    {
        //�����Ɋ�{�I�ȍU���̏���
    }

    public override bool IsAlive()
    {
        return _isAlive;
    }

}
