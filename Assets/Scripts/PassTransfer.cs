using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassTransfer : MonoBehaviour
{
    public string input;
    public GameObject canvas;
    public GameObject inputField;
    public GameObject display;
    public PlayerInteract playerInteract;

    public void StoreInput()
    {
        input = inputField.GetComponent<Text>().text;
        if (IsCorrect(playerInteract.currentInterScript.correctPass))
        {
            playerInteract.currentInterScript.locked1 = false;
            playerInteract.ifPass = false;
            canvas.SetActive(false);
            playerInteract.currentInterScript.Open(1);
        }
        else
        {
            playerInteract.currentInterScript.Open(10);
        }
        inputField.GetComponent<Text>().text = "";
    }

    public void Exit()
    {
        input = "";
        canvas.SetActive(false);
        playerInteract.ifPass = false;
    }

    public bool IsCorrect(string correct)
    {
        return correct.Equals(input);
    }
}
