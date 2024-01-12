using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//item event for usage
[System.Serializable]
public class ItemEvent : UnityEvent<Item>{}

public class Item : MonoBehaviour
{
    public bool consumable = true;
   
   //returns true if item kept, false if destroyed, calls itemmixin Use() method
   public bool Use()
   {
        ItemMixin[] mixins = GetComponents<ItemMixin>();
        foreach(ItemMixin mixin in mixins)
        {
            mixin.Use();
        }         
        return !consumable;
   }
}

/*
primary stats?
   layout
        75% stat Readout   
            75% text box
            25% text box
        25% interactible
            50% plus button
            50% minus button

            how to determine exact size:
                get screen resolution
                get size of container 
                    

panel
    meant to contain stat gameobjects / options / anything
    

*/
