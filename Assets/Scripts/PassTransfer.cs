using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassTransfer : MonoBehaviour
{
    public string input;
    public GameObject canvas;
    public GameObject inputField;
    public PlayerInteract playerInteract;

    //gets the input from the input field and depending on the input, do something in response accordingly
    public void StoreInput()
    {
        input = inputField.GetComponent<Text>().text;
        
        if (IsCorrect(playerInteract.currentInterScript.correctPass))
        {
            playerInteract.currentInterScript.locked1 = false;
            Exit();
            playerInteract.currentInterScript.Open(1);

            if (playerInteract.currentInterScript.gives1)
            {
                playerInteract.inventory.AddItem(playerInteract.currentInterScript.itemGiven1);
            }
        }
        else
        {
            Exit();
            playerInteract.currentInterScript.Open(10);
        }
        inputField.GetComponent<Text>().text = "";
    }

    //deactivate the input ui
    public void Exit()
    {
        canvas.SetActive(false);
        playerInteract.ifPass = false;
    }

    public bool IsCorrect(string correct)
    {
        input = input.Replace(" ", "");
        return correct.Equals(input);
    }
}
