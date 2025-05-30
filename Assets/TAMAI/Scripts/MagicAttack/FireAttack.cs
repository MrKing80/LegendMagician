using UnityEngine;

/// <summary>
/// �������̍U���N���X
/// �쐬�ҁF���X��
/// </summary>
[CreateAssetMenu(menuName = "Skills/FireAttack")]
public class FireAttack : BaseAttribute
{
    private const int FIRE_DAMAGE = 3;

    public FireAttack()
    {
        //�����ɂ��̃X�N���v�g�̏�����������������
    }

    public override void AttributeCharacteristics(GameObject enemy)
    {
        //TODO : ����_���[�W�̏���������
        ApplyBurnDamage(enemy);
        //TODO : ���e�����Ƃ���̒n�ʂ�R�₷�̏���������
        IgniteGround();
    }

    /// <summary>
    /// ����_���[�W�̏���
    /// ����ҁF�ʈ�
    /// </summary>
    private void ApplyBurnDamage(GameObject enemy)
    {
        enemy.GetComponent<BossEnemyClass>().TakeDamage(FIRE_DAMAGE);

        // ��Ԉُ�t�^
        Debug.Log($"{enemy}�������Ԃɂ��܂��B{enemy}��{FIRE_DAMAGE}�̉���_���[�W�I");
    }

    /// <summary>
    /// �n�ʂ�R�₷����
    /// ����ҁF�ʈ�
    /// </summary>
    private void IgniteGround()
    {
        // ���G�t�F�N�g�𐶐�
        //Instantiate();
        Debug.Log($"�t�B�[���h�������Ԃɂ��܂��B");
    }
}
