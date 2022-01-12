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
    public GameObject inputField;

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
                temp4.message = "How lovely! Please insert your coin so I can thank you for your service properly!!";
                messages[4] = temp4;
                temp5.name = " ";
                temp5.message = "Some grape juice falls down, but you her an odd clanging noise when it hits the floor.";
                messages[5] = temp5;
                temp6.name = " ";
                temp6.message = "Opening the can it smells just as bad as expected, but you find a key inside!";
                messages[6] = temp6;
                temp7.name = "Capy";
                temp7.message = "That's great and all but why are these cans so abnormally large...";
                messages[7] = temp7;
                temp8.name = " ";
                temp8.message = "You toss the foul can to the side and the key is added to your inventory.";
                messages[8] = temp8;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp9.message = "";
                messages[9] = temp9;
            }
            else if (select == 2)
            {
                animator.SetTrigger("Stare");
                temp0.name = "Vendy";
                temp0.message = "Is that a coin I see? If you'd like-";
                messages[0] = temp0;
                temp1.name = "Capy";
                temp1.message = "AHEM!";
                messages[1] = temp1;
                temp2.name = "Capy";
                temp2.message = "We've already been through this... just give me the can already.";
                messages[2] = temp2;
                temp3.name = "Vendy";
                temp3.message = "Due to your loyalty to our services you have been granted an extra can! Please insert your coin to redeem this fantastic offer!";
                messages[3] = temp3;
                temp4.name = "Capy";
                temp4.message = "What.";
                messages[4] = temp4;
                temp5.name = "Vendy";
                temp5.message = "Please insert your coin to redeem this fantastic offer!";
                messages[5] = temp5;
                temp6.name = " ";
                temp6.message = "Two cans of grape juice fall down. Ones the same as all the others but the other one...";
                messages[6] = temp6;
                temp7.name = " ";
                temp7.message = "You toss the normal can to the side and place the other near Vendy.";
                messages[7] = temp7;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp8.message = "";
                messages[8] = temp8;
            }
            else if (select == 3)
            {
                animator.SetTrigger("Capy");
                temp0.name = "Vendy";
                temp0.message = "Is that a coin I see? If you'd like some grape juice please-";
                messages[0] = temp0;
                temp1.name = "Vendy";
                temp1.message = "If you'd like some grape juice please-";
                messages[1] = temp1;
                temp2.name = "Vendy";
                temp2.message = "If you'd like some-";
                messages[2] = temp2;
                temp3.name = "Vendy";
                temp3.message = "...";
                messages[3] = temp3;
                temp4.name = "Capy";
                temp4.message = "Uhhhhhhh";
                messages[4] = temp4;
                temp5.name = "Capy";
                temp5.message = "Guess I'll insert this coin??";
                messages[5] = temp5;
                temp6.name = " ";
                temp6.message = "Against all odds a can of orange juice falls to the floor. You immediatly notice the strange... bulbus shape.";
                messages[6] = temp6;
                temp7.name = " ";
                temp7.message = "Ignoring that for now you carefully place it down.";
                messages[7] = temp7;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp8.message = "";
                messages[8] = temp8;
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
                animator.SetTrigger("Math");
                temp0.name = "Vendy";
                temp0.message = "In order to retain customer enjoyment we at Grape Inc. have incorperated a puzzle into the loyalty offer!";
                messages[0] = temp0;
                temp1.name = "Vendy";
                temp1.message = "Please use the hints on the screen to aid in your quest!";
                messages[1] = temp1;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp2.message = "";
                messages[2] = temp2;
            }
            else if (select == 6)
            {
                temp0.name = "Vendy";
                temp0.message = "...";
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
        else if (name.Equals("Passcode Can"))
        {
            if (select == 0)
            {
                //FindObjectOfType<DialogueManager>().End();
                temp0.name = "Capy";
                temp0.message = "Looks like I need a password? For some reason? This is strange.";
                messages[0] = temp0;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place
                //instead of "", the final message is "Pass" to indicate to show the input box after the message in DialogueManager
                temp1.message = "Pass";
                messages[1] = temp1;
            }
            else if (select == 1)
            {
                //FindObjectOfType<DialogueManager>().End();
                temp0.name = "Capy";
                temp0.message = "Wow it actually opened.";
                messages[0] = temp0;
                temp1.name = " ";
                temp1.message = "Looking inside Capy finds a coin... a very sticky coin.";
                messages[1] = temp1;
                temp2.name = " ";
                temp2.message = "Coin was added to inventory.";
                messages[2] = temp2;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place
                temp3.message = "";
                messages[3] = temp3;
            }
            else if (select == 4)
            {
                //FindObjectOfType<DialogueManager>().End();
                temp0.name = "Capy";
                temp0.message = "This smells even worse than the box.";
                messages[0] = temp0;
                temp1.name = "Capy";
                temp1.message = "How is that even possible...";
                messages[1] = temp1;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place
                temp2.message = "";
                messages[2] = temp2;
            }
            else if (select == 10)
            {
                //FindObjectOfType<DialogueManager>().End();
                temp0.name = " ";
                temp0.message = "Nothing happens, the password must be something else.";
                messages[0] = temp0;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place
                temp1.message = "Pass";
                messages[1] = temp1;
            }
        }
        else if (name.Equals("Orange Can"))
        {
            temp0.name = " ";
            temp0.message = "Congrats you won yeah orange in can and stuff (we haven't made a win screen yet...)";
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