using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixinHealing : ItemMixin
{
    public int healAmount = 10;
    public override void Use()
    {
        Debug.Log ("healing " + healAmount);
    }
}
