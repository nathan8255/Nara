using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    //if true object can be added to inventory
    public bool inventory;
    //if true object is openable or has a special interaction
    public bool openable;
    //if true object is locked or has yet to perform a special interaction
    public bool locked1;
    public bool locked2;
    public bool locked3;
    //if true object gives an item at the appropriate lock
    public bool gives1;
    public bool gives2;
    public bool gives3;
    //if true there's dialogue associated with the item (and nothing else)
    public bool ifDialogue;
    //if true the item is an orange
    public bool ifOrange;
    //if true a password is needed to interact with this item
    public bool password;
    //correct password 
    public string correctPass;
    //item(s) needed to interact with this item
    public GameObject itemNeeded1 = null;
    public GameObject itemNeeded2 = null;
    public GameObject itemNeeded3 = null;
    public GameObject itemNeeded4 = null;
    //item(s) given by item
    public GameObject itemGiven1 = null;
    public GameObject itemGiven2 = null;
    public GameObject itemGiven3 = null;

    public DialogueTrigger dialogue;

    public void DoInteraction()
    {
        if (ifDialogue)
        {
            //if the object can only run dialogue send it to StartDialogue with it's name and 0; only possible interaction
            dialogue.StartDialogue(gameObject.name, 0);
        }
        if (inventory)
        {
            //same as before except "you picked up ______" dialogue; selection is set to 100 to make life easier
            dialogue.StartDialogue(gameObject.name, 100);
            //picked up and put in inventory
            gameObject.SetActive(false);
        }
    }

    public void Open(int selection)
    {
        dialogue.StartDialogue(gameObject.name, selection);
    }
}
