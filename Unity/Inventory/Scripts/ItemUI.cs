using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

//create ui event for inspector
[System.Serializable]
public class ItemUIEvent : UnityEvent<ItemUI>{}

public class ItemUI : MonoBehaviour
{
    //intsance of event
    public ItemUIEvent onClicked;


    //slot for item gameobject
    public Item item;
    //text box for item display
    public Text itemName;

   
    // Start is called before the first frame update
    void Start()
    {
        //null check followed by item display
        if (item)
            Display(item);
        
    }

     //sets this instance of item into item slot and sets name in text
    public virtual void Display(Item item)
    {
        this.item = item;
        itemName.text = item.name;
    }

    //invoke unityevent tied to inspector
    public virtual void Click()
    {
        onClicked?.Invoke (this);
        
    }

}
