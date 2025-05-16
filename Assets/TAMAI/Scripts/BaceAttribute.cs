using UnityEngine;

public abstract class BaceAttribute : MonoBehaviour
{

    public BaceAttribute(int a)
    {
        var B = a;
    }
    // qƒNƒ‰ƒX‚ÅŒp³‚·‚é
    protected abstract string AttributeName();
    protected abstract float MagicAttackPower();

}
