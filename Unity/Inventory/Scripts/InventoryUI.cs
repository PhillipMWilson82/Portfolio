//IMPORTANT READ BACK UP ON UNITY MANUAL UI, CANVASES, RENDER MODES, AND ESPECIALLY WORLD CANVASES
//RENDER MODE: Canvas overlay always need to be a top layer of canvas, regardless of other nested canvases
/*
Perko tutorial does something that i left out because it worked without it:
            he added a bool showPlayerInventory
            In Start, he changed the current code to an if/else
            it triggered the display of Playerinventory if the bool was true
            considering that the inspector already has the content linked, display triggers for it already
            i dont understand the need for a distinction since there are already two inventoryUI classes
            this might change as i learn more or proceed further           

*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryUI : MonoBehaviour
{
    #region Variables

    //contents of visual display
    public Inventory inventory;
    //gameobject that displays content
    public Transform content;
    //prefab for itemdisplay
    public ItemUI itemUIPrefab;

    public ItemEvent itemSelected;
    
    #endregion

    #region Unity Functions

    // nullcheck inventory and call display function
    void Start()
    {
        if (inventory)
            Display(inventory);        
    }

    #endregion

    #region Display Functions

    //set inventory to i and then refresh visual
    public virtual void Display(Inventory i)
    {
        
        //ensure that previous event is signed off
        if (this.inventory) {
            this.inventory.onChanged.RemoveListener (Refresh);
        }
        this.inventory = i;
        this.inventory.onChanged.AddListener(Refresh);
        Refresh();
    }

    //destroy previous items displayed and repopulate
    //listeners added on creation of new objects
    public virtual void Refresh()
    {
        foreach (Transform t in content)
        {
            Destroy(t.gameObject);
        }

        foreach (Item i in inventory.items)
        {
            ItemUI ui = ItemUI.Instantiate (itemUIPrefab, content);
            ui.onClicked.AddListener(UIClicked);
            ui.Display(i);
        }
    }

    #endregion
  
    #region EventResponders

         //triggers whenever itemUI is clicked, recieves specific item and adds/removes inventory in response
         public virtual void UIClicked(ItemUI iui)
        {
           itemSelected?.Invoke(iui.item);

            //removed and replaced by event call
            //Inventory.playerInventory.AddItem(iui.item);
            //inventory.RemoveItem(iui.item);
        }

        public void AddToInventory(Item item)
        {
            Inventory.playerInventory.AddItem(item);
        }
        public void RemoveFromInventory(Item item)
        {
            inventory.RemoveItem(item);
        }
        public void Use (Item item)
        {
            if (!item.Use())
                RemoveFromInventory (item);
        }
    #endregion

}
