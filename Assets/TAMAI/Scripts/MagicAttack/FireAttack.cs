using UnityEngine;
using System;

public class FireAttack : BaceAttribute
{
    private string _attributeName = "";

    public FireAttack(string attributeName)
    {
        _attributeName = attributeName;
    }

    protected override void AttributeCharacteristics()
    {
        //TODO : 炎上ダメージの処理を書く
        //TODO : 着弾したところの地面を燃やすの処理を書く.
    }
}
