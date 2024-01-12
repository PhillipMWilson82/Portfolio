using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixinStatBoost : ItemMixin
{
    public string stat = "Strength";
    public int amount = 3;
    public override void Use()
    {
        Debug.Log ("boosting " + stat + " + " + amount);
    }
}
