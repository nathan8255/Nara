using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    //https://www.youtube.com/watch?v=PswC-HlKZqA&ab_channel=CocoCode

    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;
    public GameObject inventory;

    Message[] currentMessages;
    int activeMessage = 0;
    public static bool isActive = false;

    public void OpenDialogue(Message[] messages)
    {
        //resets all appropriate variables upon the start of a new dialogue
        inventory.SetActive(false);
        currentMessages = messages;
        activeMessage = 0;
        isActive = true;

        Debug.Log("Started conversation! Loaded messages: " + messages.Length);
        DisplayMessage();
        //makes the UI visible
        backgroundBox.transform.localScale = new Vector3(100, 100, 1);
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        //all unused values in the messages array are set to "", "" - this checks if the current message is empty and ends the dialogue if it is
        if (messageToDisplay.message.Equals("")) {
            Debug.Log("Conversation ended.");
            isActive = false;
            inventory.SetActive(true);
            //makes the UI invisible
            backgroundBox.transform.localScale = Vector3.zero;
        }
        else
        {
            messageText.text = messageToDisplay.message;
            actorName.text = messageToDisplay.name;
        }
    }

    public void NextMessage()
    {
        activeMessage++;

        //as long as we haven't reached the end of the array keep calling back to DisplayMessage()
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else 
        {
            Debug.Log("Conversation ended.");
            isActive = false;
            inventory.SetActive(true);
            //makes the UI invisible
            backgroundBox.transform.localScale = Vector3.zero;
        }
    }

    //ends dialogue
    public void End()
    {
        Debug.Log("Conversation ended.");
        isActive = false;
        inventory.SetActive(true);
        //makes the UI invisible
        backgroundBox.transform.localScale = Vector3.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        //makes the UI invisible
        backgroundBox.transform.localScale = Vector3.zero;
        inventory.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //while a dialogue interaction is occuring; checks if the space key is being pressed, if it is progress the dialogue
        if (isActive && Input.GetKeyDown(KeyCode.Space))
        {
            NextMessage();
        }
    }
}
