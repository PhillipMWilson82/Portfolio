using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    //reference to player inventory
    public static Inventory playerInventory;

    //list of all items contained within inventory
    public List<Item> items;

    //bool to determine if player inventory or not
    //not best solution but termporarily will do
    public bool isPlayerInventory = false;

    //meant to update visual display of inventory
    public UnityEvent onChanged;

    //check and set player inventory
    public virtual void Awake()
    {
        if (isPlayerInventory)
            playerInventory = this;
    }

    //Add items to inventory list
    public virtual void AddItem(Item item)
    {
        items.Add(item);
        onChanged?.Invoke();
    }

    //remove items from inventory list
    public virtual void RemoveItem(Item item)
    {
        //ensure that the item exists in the inventory
        if (!items.Contains (item))
            return;
        items.Remove (item);
        onChanged?.Invoke();
    }
 
}
