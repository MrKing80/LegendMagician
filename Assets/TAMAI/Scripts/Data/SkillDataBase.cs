using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// スキルデータベース
/// 制作者：玉井
/// </summary>
[CreateAssetMenu]
public class SkillDataBase : ScriptableObject
{
    public List<BaseAttribute> _skillDatas = new List<BaseAttribute>();
}
