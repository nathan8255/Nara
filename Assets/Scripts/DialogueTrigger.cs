using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class DialogueTrigger : MonoBehaviour
{
    //https://www.youtube.com/watch?v=PswC-HlKZqA&ab_channel=CocoCode

    //in Unity the length of messeges is set to 40 to ensure that any dialogue can be displayed within the realms of what we need
    public Message[] messages;
    public Animator animator;
    public InteractableObject currentInterScript;

    public void StartDialogue(string name, int select)
    {
        //if the player is currently in a dialogue interaction don't allow them to click on the object
        if (DialogueManager.isActive) return;
        Message temp0 = new Message();
        Message temp1 = new Message();
        Message temp2 = new Message();
        Message temp3 = new Message();
        Message temp4 = new Message();
        Message temp5 = new Message();
        Message temp6 = new Message();
        Message temp7 = new Message();
        Message temp8 = new Message();
        Message temp9 = new Message();

        if (name.Equals("Vending Machine"))
        {
            //dialogueSelect will be modified via other scripts as different conditions are fulfilled - changing what is said
            if (select == 0)
            {
                temp0.name = "Vendy";
                temp0.message = "Thanks for choosing Grape Inc. Would you like some grape juice? It only costs one coin!";
                messages[0] = temp0;
                temp1.name = "Capy";
                temp1.message = "No, ew. Do you have any orange juice?";
                messages[1] = temp1;
                temp2.name = "Vendy";
                temp2.message = "Would you like some grape juice? It only costs one coin!";
                messages[2] = temp2;
                temp3.name = "Capy";
                temp3.message = "Disgusting.";
                messages[3] = temp3;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp4.message = "";
                messages[4] = temp4;
            } 
            else if (select == 1)
            {
                animator.SetTrigger("Smile");
                temp0.name = "Vendy";
                temp0.message = "Is that a coin I see? If you'd like some grape juice please insert your coin into the coin slot!";
                messages[0] = temp0;
                temp1.name = "Capy";
                temp1.message = "....";
                messages[1] = temp1;
                temp2.name = "Vendy";
                temp2.message = "If you'd like some grape juice please insert your coin into the coin slot! I could see how parched you are from miles away, just try some!";
                messages[2] = temp2;
                temp3.name = "Capy";
                temp3.message = "...fine. Make sure to stock orange juice next time.";
                messages[3] = temp3;
                temp4.name = "Vendy";
                temp4.message = "How lovely! Please insert your coin so I can thank you for your service properly :D";
                messages[4] = temp4;
                temp5.name = " ";
                temp5.message = "Some grape juice falls down, but you her an odd clanging noise when it hits the floor.";
                messages[5] = temp5;
                temp6.name = " ";
                temp6.message = "Opening the can it smells just as bad as expected, but you find a key inside!";
                messages[6] = temp6;
                temp7.name = " ";
                temp7.message = "You toss the foul can to the side and the key is added to your inventory.";
                messages[7] = temp7;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp8.message = "";
                messages[8] = temp8;
            }
            else if (select == 2)
            {
                animator.SetTrigger("Stare");
                temp0.name = "Vendy";
                temp0.message = "Nathan has yet to write this interaction (you have Coin2).";
                messages[0] = temp0;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp1.message = "";
                messages[1] = temp1;
            }
            else if (select == 4)
            {
                temp0.name = "Vendy";
                temp0.message = "Thanks so much for your service! If you ever come acorss another coin feel free to have some more grape juice!";
                messages[0] = temp0;
                temp1.name = "Capy";
                temp1.message = "...";
                messages[1] = temp1;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp2.message = "";
                messages[2] = temp2;
            }
            else if (select == 5)
            {
                temp0.name = "Vendy";
                temp0.message = "Nathan has yet to write this interaction (you've already inserted Coin2 and don't have Coin3).";
                messages[0] = temp0;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp1.message = "";
                messages[1] = temp1;
            }
        }
        else if (name.Equals("Grape Cans"))
        {
            temp0.name = "Capy";
            temp0.message = "I really wish there was orange juice available.";
            messages[0] = temp0;
            temp1.name = "Capy";
            temp1.message = "What kind of convenience store only sells one thing anyway...";
            messages[1] = temp1;
            //set the message after this dialogue is completed to nothing to stop dialogue at right place 
            temp2.message = "";
            messages[2] = temp2;
        }
        else if (name.Equals("Box"))
        {
            if (select == 0)
            {
                temp0.name = "Capy";
                temp0.message = "That box looks really unlockable...";
                messages[0] = temp0;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp1.message = "";
                messages[1] = temp1;
            }
            else if (select == 1)
            {
                animator.SetTrigger("Unlocked");
                temp0.name = " ";
                temp0.message = "Capy puts the key in the box and it's a perfect fit!";
                messages[0] = temp0;
                temp1.name = " ";
                temp1.message = "Coin was added to inventory.";
                messages[1] = temp1;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place
                temp2.message = "";
                messages[2] = temp2;
            }
            else if (select == 4)
            {
                temp0.name = "Capy";
                temp0.message = "There's nothing left inside... and it smells like grapes. Ew.";
                messages[0] = temp0;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp1.message = "";
                messages[1] = temp1;
            }
        }
        else if (name.Equals("Broken Door"))
        {
            temp0.name = "Capy";
            temp0.message = "Oops.";
            messages[0] = temp0;
            //set the message after this dialogue is completed to nothing to stop dialogue at right place
            temp1.message = "";
            messages[1] = temp1;
        }
        else if (select == 100)
        {
            temp0.name = " ";
            temp0.message = name + " was added to inventory.";
            messages[0] = temp0;
            //set the message after this dialogue is completed to nothing to stop dialogue at right place
            temp1.message = "";
            messages[1] = temp1;
        } 
        //connects DialogueTrigger to DialogueManager
        FindObjectOfType<DialogueManager>().OpenDialogue(messages);
    }
}

[System.Serializable]
public class Message
{
    public string name;
    public string message;
}