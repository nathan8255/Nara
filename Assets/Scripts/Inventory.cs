using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class Inventory : MonoBehaviour
{
    [SerializeField]
    public GameObject[] inventory = new GameObject[8];
    public Button[] InventorySlots = new Button[8];

    public void AddItem(GameObject item)
    {

        bool itemAdded = false;

        //find first open slot in inventory
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = item;
                //update UI
                InventorySlots[i].image.overrideSprite = item.GetComponent<SpriteRenderer>().sprite;
                Debug.Log(item.name + " added to inventory");
                itemAdded = true;
                break;
            }
        }

        //inventory was full
        if (!itemAdded)
        {
            Debug.Log("inventory full - " + item.name + " was not added");
        }
    }

    public bool FindItem(GameObject item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            //item found
            if (inventory[i] == item) return true;
        }
        //item not found
        return false;
    }

    public void RemoveItem(GameObject item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == item)
            {
                inventory[i] = null;
                Debug.Log(item.name + " was removed from inventory.");
                //update UI
                InventorySlots[i].image.overrideSprite = null;
                break;
            }
        }
    }
}
