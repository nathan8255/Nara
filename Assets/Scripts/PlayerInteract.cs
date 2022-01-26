using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{
    //https://www.youtube.com/watch?v=gGUtoy4Knnw&list=PLa5_l08N9jzM7s58ly3K5ZXYypX8AyWiS&ab_channel=ScriptingIsFun

    public GameObject currentObject = null;
    public InteractableObject currentInterScript = null;
    public Inventory inventory;
    public PassTransfer passTransfer;
    public GameObject inputField;
    public InputField inputFieldText;
    Scene currentScene;

    public bool ifPass = false;

    void Update()
    {
        //check if the lights are off in barabar, and register any "Interact" input as turning the lights back on.
        //capy sometimes cannot interact with an object without leaving and reentering the boxcollider sometimes, 
        //and since capy stands still when lights are off, this helps to avoid bugs
        if (currentScene.name.Equals("Barabar"))
        {
            if ((Input.GetButtonDown("Interact") && FindObjectOfType<LightsOnOff>().lightsOff.activeSelf && DialogueManager.isActive))
            {
                currentInterScript.Open(10);
                FindObjectOfType<LightsOnOff>().TurnLightsOn();
            }
        }
        
        //if there is an Interact input, and if there is a currentObject, and if a passcode isn't beinging inputted
        if (Input.GetButtonDown ("Interact") && currentObject && !ifPass)
        {
            //check if object is to be storied in inventory
            if(currentInterScript.inventory)
            {
                inventory.AddItem(currentObject);
            }

            //check if object is an orange; if it is change to the win screen
            if (currentInterScript.ifOrange)
            {
                SceneManager.LoadScene("WinScreen");
                return;
            }

            //specific case where you need an item to to be able to input password into object
            if (currentInterScript.openable && currentInterScript.password)
            {
                if (currentInterScript.locked1)
                {
                    //check if the inventory contains the neccesary object to unlock
                    if (inventory.FindItem(currentInterScript.itemNeeded1))
                    {
                        //item was found
                        currentInterScript.locked1 = false;
                        Debug.Log(currentObject.name + " was unlocked");
                        //this has been modifiyed for the one case in which we use it - where four items must be removed from inventory
                        //if we wanted to further expand we would have to include some if statements and whatnot
                        inventory.RemoveItem(currentInterScript.itemNeeded1);
                        inventory.RemoveItem(currentInterScript.itemNeeded2);
                        inventory.RemoveItem(currentInterScript.itemNeeded3);
                        inventory.RemoveItem(currentInterScript.itemNeeded4);
                        currentInterScript.Open(2);
                        //if interaction gives an item, add said item to inventory
                        if (currentInterScript.gives1)
                        {
                            inventory.AddItem(currentInterScript.itemGiven1);
                        }
                    }
                    else
                    {
                        //if locked1 is true and the item was not found run default dialogue
                        currentInterScript.Open(0);
                        Debug.Log(currentObject.name + " was not unlocked, " + currentInterScript.itemNeeded1.name + " needed");
                    }
                }
                else if (currentInterScript.locked2)
                {
                    //if locked2 is true, meaning password hasn't been inputted yet, play default dialogue
                    currentInterScript.Open(4);
                }
                else
                {
                    currentInterScript.Open(5);
                }
            }
            //check if the object can be opened or has a special interaction
            else if (currentInterScript.openable)
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
                        //if locked2 is true and the item was not found run default dialogue
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
            else if (currentInterScript.password)
                //if password is true
            {
                if (currentInterScript.locked1)
                {
                    //if locked1 is true, meaning password hasn't been inputted yet, play default dialogue
                    currentInterScript.Open(0);
                }
                else
                {
                    currentInterScript.Open(4);
                }
            }
            else if (currentInterScript.lightsOn)
            {
                //check if the lights are on or off, and then turn them off or on and play dialogue accordingly
                if(!FindObjectOfType<LightsOnOff>().lightsOff.activeSelf)
                {
                    currentInterScript.Open(0);
                    FindObjectOfType<LightsOnOff>().TurnLightsOff();
                }
                else if (FindObjectOfType<LightsOnOff>().lightsOff.activeSelf)
                {
                    currentInterScript.Open(1);
                    FindObjectOfType<LightsOnOff>().TurnLightsOn();
                }
            }
            
            currentObject.SendMessage("DoInteraction");
        }
    }

    //DialogueManager calls this to open the Input UI 
    public void OpenInputField() {
        ifPass = true;
        inputField.SetActive(true);
        //automatically select the text in the input field when opened
        inputFieldText.Select();
    }

    void Start()
    {
        inputField.SetActive(false);
        currentScene = SceneManager.GetActiveScene();
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
