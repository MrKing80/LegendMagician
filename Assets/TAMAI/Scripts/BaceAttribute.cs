using UnityEngine;

public abstract class BaceAttribute : MonoBehaviour
{

    public BaceAttribute(int a)
    {
        var B = a;
    }
    // �q�N���X�Ōp������
    protected abstract string AttributeName();
    protected abstract float MagicAttackPower();

}
