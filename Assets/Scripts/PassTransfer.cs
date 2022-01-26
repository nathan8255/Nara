using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PassTransfer : MonoBehaviour
{
    //https://www.youtube.com/watch?v=zc8ac_qUXQY&ab_channel=Brackeys

    public string input;
    public GameObject canvas;
    public GameObject inputField;
    public PlayerInteract playerInteract;

    //gets the input from the input field and depending on the input, do something in response accordingly
    //math answer: 845
    //drink mix answer: 2G5P3B4R
    public void StoreInput()
    {
        if (playerInteract.currentObject.name.Equals("Drink Mixer"))
        {
            FindObjectOfType<AudioManager>().Play("Drink Mixer");
        }
        input = inputField.GetComponent<Text>().text;
        
        if (IsCorrect(playerInteract.currentInterScript.correctPass))
        {
            if (!playerInteract.currentInterScript.locked1)
            {
                playerInteract.currentInterScript.locked2 = false;
            }
            else
            {
                playerInteract.currentInterScript.locked1 = false;
            }

            Exit();
            playerInteract.currentInterScript.Open(1);

            if (playerInteract.currentInterScript.gives1)
            {
                playerInteract.inventory.AddItem(playerInteract.currentInterScript.itemGiven1);
            }
            else if (playerInteract.currentInterScript.gives2)
            {
                playerInteract.inventory.AddItem(playerInteract.currentInterScript.itemGiven2);
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
        return correct.Equals(input, StringComparison.OrdinalIgnoreCase);
    }
}
