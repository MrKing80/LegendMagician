using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �X�L���f�[�^�x�[�X
/// ����ҁF�ʈ�
/// </summary>
[CreateAssetMenu]
public class SkillDataBase : ScriptableObject
{
    public List<BaseAttribute> _skillDatas = new List<BaseAttribute>();
}
