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

        //when select =...
        //0, default dialogue
        //1, something(1) was just unlocked, reaction dialogue
        //2, something(2) was just unlocked, reaction dialogue
        //3, something(3) was just unlocked, reaction dialogue
        //4, something(1) has already been unlocked, but something(2) has not been unlocked yet
        //5, something(2) has already been unlocked, but something(3) has not been unlocked yet
        //6, something(3) has already been unlocked
        //10, the wrong password was typed in
        //100, something was added to the inventory

        if (select == 100)
        {
            temp0.name = " ";
            temp0.message = name + " was added to inventory.";
            messages[0] = temp0;
            //set the message after this dialogue is completed to nothing to stop dialogue at right place
            temp1.message = "";
            messages[1] = temp1;
        }

        switch (name)
        {
            case "Vending Machine":
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
                    temp5.message = "Some grape juice falls down, but you hear an odd clanging noise when it hits the floor.";
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
                    temp6.message = "Two cans of grape juice fall down. One is the same as all the others but the other one...";
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
                    temp6.message = "Against all odds a can of orange juice falls to the floor. You immediately notice the strange... bulbus shape.";
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
                    temp0.message = "Thanks so much for your service! If you ever come across another coin feel free to have some more grape juice!";
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
                break;


            case "Grape Cans":
                temp0.name = "Capy";
                temp0.message = "I really wish there was orange juice available.";
                messages[0] = temp0;
                temp1.name = "Capy";
                temp1.message = "What kind of convenience store only sells one thing anyway...";
                messages[1] = temp1;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp2.message = "";
                messages[2] = temp2;
                break;
            case "Box":
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
                break;

            case "Broken Door":
                temp0.name = "Capy";
                temp0.message = "Oops.";
                messages[0] = temp0;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place
                temp1.message = "";
                messages[1] = temp1;
                break;

            case "Passcode Can":
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
                break;

            case "Orange Can":
                temp0.name = " ";
                temp0.message = "Congrats you won yeah orange in can and stuff (we haven't made a win screen yet...)";
                messages[0] = temp0;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                temp1.message = "";
                messages[1] = temp1;
                break;

            case "Drink Mixer":
                if (select == 0)
                {
                    temp0.name = "Capy";
                    temp0.message = "A drink mixer huh...";
                    messages[0] = temp0;
                    temp1.name = "Capy";
                    temp1.message = "I'll need something to mix to use this.";
                    messages[1] = temp1;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp2.message = "";
                    messages[2] = temp2;
                }
                else if (select == 1)
                {
                    temp0.name = "Capy";
                    temp0.message = "Wow! That was actually pretty easy.";
                    messages[0] = temp0;
                    temp1.name = "Capy";
                    temp1.message = "You could call me a...";
                    messages[1] = temp1;
                    temp2.name = "Capy";
                    temp2.message = "Capybartender.";
                    messages[2] = temp2;
                    temp3.name = " ";
                    temp3.message = "Mixed Drink was added to inventory.";
                    messages[3] = temp3;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp4.message = "";
                    messages[4] = temp4;
                }
                else if (select == 2)
                {
                    temp0.name = "Capy";
                    temp0.message = "Okay I have four drinks now.";
                    messages[0] = temp0;
                    temp1.name = "Capy";
                    temp1.message = "That sounds like a good amount I think.";
                    messages[1] = temp1;
                    temp2.name = "Capy";
                    temp2.message = "Lemme just open this...";
                    messages[2] = temp2;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp3.message = "";
                    messages[3] = temp3;
                }
                else if (select == 4)
                {
                    temp0.name = "Capy";
                    temp0.message = "I'll try my best!";
                    messages[0] = temp0;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp1.message = "Pass";
                    messages[1] = temp1;
                }
                else if (select == 5)
                {
                    temp0.name = "Capy";
                    temp0.message = "Do you think they'd notice if I took this with me...";
                    messages[0] = temp0;
                    temp1.name = "Capy";
                    temp1.message = "I'm just so good at... capybartending...";
                    messages[1] = temp1;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp2.message = "";
                    messages[2] = temp2;
                }
                else if (select == 10)
                {
                    temp0.name = "Capy";
                    temp0.message = "Something must have gone wrong because this doesn't look edible...";
                    messages[0] = temp0;
                    temp1.name = "Capy";
                    temp1.message = "Let's try this again.";
                    messages[1] = temp1;
                    //put better comment here 
                    temp2.message = "Pass";
                    messages[2] = temp2;
                }
                break;

            case "Blender":
                if (select == 0)
                {
                    temp0.name = "Capy";
                    temp0.message = "Looks like I can open this if I never need to blend something.";
                    messages[0] = temp0;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                    temp1.message = "";
                    messages[1] = temp1;
                }
                else if (select == 1)
                {
                    FindObjectOfType<AudioManager>().Play("Blender");
                    temp0.name = " ";
                    temp0.message = "Capy dumps the drink in the blender and puts it on high speed.";
                    messages[0] = temp0;
                    temp1.name = " ";
                    temp1.message = "For some reason that defies physics as you know it, the drink turns into a... key?";
                    messages[1] = temp1;
                    temp2.name = " ";
                    temp2.message = "Purple Key was added to inventory.";
                    messages[2] = temp2;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp3.message = "";
                    messages[3] = temp3;
                }
                else if (select == 4)
                {
                    temp0.name = "Capy";
                    temp0.message = "Bzzz bzzz...";
                    messages[0] = temp0;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place 
                    temp1.message = "";
                    messages[1] = temp1;
                }
                break;

            case "Drink Formats Poster":
                temp0.name = "Capy";
                temp0.message = "So this is how barabartenders makes drinks?";
                messages[0] = temp0;
                temp1.name = "Capy";
                temp1.message = "This seems incredible impractical...";
                messages[1] = temp1;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place
                temp2.message = "";
                messages[2] = temp2;
                break;

            case "Computer":
                temp0.name = " ";
                temp0.message = "You press the power button, but nothing seems to happen.";
                messages[0] = temp0;
                temp1.name = "Capy";
                temp1.message = "I'm not the most adept at technology stuff but I think I could press a power button.";
                messages[1] = temp1;
                temp2.name = "Capy";
                temp2.message = "Guess this thing just doesn't work.";
                messages[2] = temp2;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place
                temp3.message = "";
                messages[3] = temp3;
                break;

            case "Cabinet Door":
                if (select == 0)
                {
                    temp0.name = "Capy";
                    temp0.message = "The orange is right there!";
                    messages[0] = temp0;
                    temp1.name = "Capy";
                    temp1.message = "...Of course, the door is locked.";
                    messages[1] = temp1;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp2.message = "";
                    messages[2] = temp2;
                } 
                else if (select == 1)
                {
                    animator.SetTrigger("Open");
                    currentInterScript.ifOrange = true;
                    temp0.name = "Capy";
                    temp0.message = "I hope this purple key is the right one.";
                    messages[0] = temp0;
                    temp1.name = " ";
                    temp1.message = "Capy twisted the strange, purple key into the cabinet door's lock.";
                    messages[1] = temp1;
                    temp2.name = " ";
                    temp2.message = "The cabinet door unlocked and swung wide open!";
                    messages[2] = temp2;
                    temp3.name = "Capy";
                    temp3.message = "Yes! Give me the orange!";
                    messages[3] = temp3;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp4.message = "";
                    messages[4] = temp4;
                }
                else if (select == 2)
                {
                    temp0.name = "";
                    messages[0] = temp0;
                }
                break;

            case ("Light Switch Door"):
                if (select == 0)
                {
                    //lights were on, and will be turned off
                    temp0.name = "";
                    temp0.message = "Capy pulled on the cabinet door. The door didn't budge, and instead, the lights turned off.";
                    messages[0] = temp0;
                    temp1.name = "Capy";
                    temp1.message = "AHHHHHHH!!! THERE'S NO WAY I CAN EXPLORE IN THE DARK, IT'S TOO SCARY.";
                    messages[1] = temp1;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp2.message = "";
                    messages[2] = temp2;
                } 
                else if (select == 1)
                {
                    //lights were off, and will be turned on
                    temp0.name = "";
                    temp0.message = "Capy pulled on the cabinet door. Instead of opening, the lights turned on.";
                    messages[0] = temp0;
                    temp1.name = "Capy";
                    temp1.message = "Ahem. Much better.";
                    messages[1] = temp1;
                    //set the message after this dialogue is completed to nothing to stop dialogue at right place
                    temp2.message = "";
                    messages[2] = temp2;
                }
                break;

            case ("Ladder"):
                temp0.name = "Capy";
                temp0.message = "A conveniently-placed, capybara-safe ladder to get to the countertop. Huh.";
                messages[0] = temp0;
                //set the message after this dialogue is completed to nothing to stop dialogue at right place
                temp1.message = "";
                messages[1] = temp1;
                break;

            default:
                break;
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