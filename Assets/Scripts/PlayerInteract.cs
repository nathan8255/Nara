using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentObject = null;
    public InteractableObject currentInterScript = null;
    public Inventory inventory;

    void Update()
    {
        if (Input.GetButtonDown ("Interact") && currentObject)
        {
            /*
             * set up a shit ton of bools
             * change the start dialogue to include an int or something that selects the interaction
             * also have posibility for multiple locked variables (looks at vending machine...)
             * have it do the inventory stuff in here and then call the startDialogue method with the object name and the int seleciton; change open method to do this
             * eg. if you interact with the vending machine and you don't have the coin: currentInterScript.Open(0) [open has name in it already]
             * but if you do have the coin, turn of locked1 and pass: currentInterScript.Open(1)
             * in the dialogueTrigger method it will take in the object name as usual, but also the selection variable 
             * instead of checking for all the shit in there just have it do the appropriate dialogue for the situation decided in this script
             * 
             * further example - for the box if don't have the key do nothing in here and display "i wish i had a key": currentInterScript.Open(0)
             * if you do have the key add the coin in here, turn off locked and pass: currentInterScript.Open(1)
             * oh yeah also put animation in Open() for 1 and all that 
             * 
             * CLEAN THIS SHIT UP ALSO THERE'S SO MUCH UNESSECARY SHIT IN THESE SCRIPTS NOW LOLO
             */

            //check if object is to be storied in inventory
            if(currentInterScript.inventory)
            {
                inventory.AddItem(currentObject);
            }

            //check if the object can be opened or has a special interaction
            if (currentInterScript.openable)
            {
                //check if the object is locked(1) or has yet to perform a special interaction
                if (currentInterScript.locked1)
                {
                    //check if the inventory contains the neccesary object to unlock
                    if (inventory.FindItem (currentInterScript.itemNeeded1))
                    {
                        //item was found
                        currentInterScript.locked1 = false;
                        Debug.Log(currentObject.name + " was unlocked");
                        //removes item after it was used 
                        inventory.RemoveItem(currentInterScript.itemNeeded1);
                        currentInterScript.Open(1);
                        //if interaction gives an item, add said item to inventory
                        if (currentInterScript.gives1)
                        {
                            inventory.AddItem(currentInterScript.itemGiven1);
                        }
                    } else {
                        //if locked1 is true and the item was not found run default dialogue
                        currentInterScript.Open(0);
                        Debug.Log(currentObject.name + " was not unlocked, " + currentInterScript.itemNeeded1.name + " needed");
                    }
                }
                //check if the object is locked(2) or has yet to perform a special interaction
                else if (currentInterScript.locked2)
                {
                    //check if the inventory contains the neccesary object to unlock
                    if (inventory.FindItem(currentInterScript.itemNeeded2))
                    {
                        //item was found
                        currentInterScript.locked2 = false;
                        Debug.Log(currentObject.name + " was unlocked");
                        //removes item after it was used 
                        inventory.RemoveItem(currentInterScript.itemNeeded2);
                        currentInterScript.Open(2);
                        //if interaction gives an item, add said item to inventory
                        if (currentInterScript.gives2)
                        {
                            inventory.AddItem(currentInterScript.itemGiven2);
                        }
                    } else {
                        //if locked1 is true and the item was not found run default dialogue
                        currentInterScript.Open(4);
                        Debug.Log(currentObject.name + " was not unlocked, " + currentInterScript.itemNeeded2.name + " needed");
                    }
                }
                //check if the object is locked(3) or has yet to perform a special interaction
                else if (currentInterScript.locked3)
                {
                    //check if the inventory contains the neccesary object to unlock
                    if (inventory.FindItem(currentInterScript.itemNeeded3))
                    {
                        //item was found
                        currentInterScript.locked3 = false;
                        Debug.Log(currentObject.name + " was unlocked");
                        //removes item after it was used 
                        inventory.RemoveItem(currentInterScript.itemNeeded3);
                        currentInterScript.Open(3);
                        //if interaction gives an item, add said item to inventory
                        if (currentInterScript.gives3)
                        {
                            inventory.AddItem(currentInterScript.itemGiven3);
                        }
                    } else {
                        //if locked1 is true and the item was not found run default dialogue
                        currentInterScript.Open(5);
                        Debug.Log(currentObject.name + " was not unlocked, " + currentInterScript.itemNeeded3.name + " needed");
                    }
                }
            }
            currentObject.SendMessage("DoInteraction");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interactable"))
        {
            Debug.Log("in " + other.name + " range");
            currentObject = other.gameObject;
            currentInterScript = currentObject.GetComponent<InteractableObject>();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("interactable"))
        {
            if(other.gameObject == currentObject)
            {
                Debug.Log("leaving " + other.name + " range");
                currentObject = null;
            }
        }
    }
}
