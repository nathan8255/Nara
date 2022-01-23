using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cans : MonoBehaviour
{
    public InteractableObject vendyScript;
    public GameObject pear;
    public GameObject passcode;
    public GameObject banana;
    public GameObject orange;
    bool isMove;
    

    void Start()
    {
        pear.SetActive(false);
        passcode.SetActive(false);
        banana.SetActive(false);
        orange.SetActive(false);
        isMove = false;
        
    }
    // Update is called once per frame
    void Update()
    {
        // if the banana can hasn't been revealed yet (banana.activeSelf), check if vendy has received their coin (vendyScript.locked1)
        // ,wait until dialogue is inactive, and then play the tossing movement animation
        if (!vendyScript.locked1 && !banana.activeSelf && !DialogueManager.isActive)
        {
            //coroutines let program multitask so long tasks don't interrupt or make the program unresponsive for a few seconds 
            StartCoroutine(BananaCan());
        }
        if (!vendyScript.locked2 && !pear.activeSelf && !DialogueManager.isActive)
        {
            StartCoroutine(PearCan());
            StartCoroutine(PasscodeCan());
        }
        if (!vendyScript.locked3 && !orange.activeSelf && !DialogueManager.isActive)
        {
            StartCoroutine(OrangeCan());
        }
    }

    private void FixedUpdate()
    {
        //move the proper can in a certain direction, stop when isMove = false
        //the values in new Vector2(a,b) are just trialed and errored to point the can in the proper direction. the next number (eg. 6f) is the movement speed
        if (isMove)
        {
            if (!pear.activeSelf)
            {
                banana.transform.Translate(new Vector2(-1.4f, -1f) * 6f * Time.deltaTime);
            }
            else if (!passcode.activeSelf)
            {
                pear.transform.Translate(new Vector2(1f, 2.4f) * 4f * Time.deltaTime);
                

            }
            else if (!orange.activeSelf)
            {
                passcode.transform.Translate(new Vector2(0.5f, -2f) * 2.2f * Time.deltaTime);
            }
            else
            {
                orange.transform.Translate(new Vector2(-1.8f, -2f) * 2.3f * Time.deltaTime);
            }
            
        }
        
    }

    //reveal banana can and move it
    IEnumerator BananaCan() {

        banana.SetActive(true);
        isMove = true;
        FindObjectOfType<AudioManager>().Play("Whoop");
        float duration = (float)1.2;
        //wait for a duration of time before stopping movement and playing next sound effect
        yield return new WaitForSeconds(duration);
        isMove = false;
        FindObjectOfType<AudioManager>().Play("Glass Break");
        
    }

    //reveal pear can and move it
    IEnumerator PearCan()
    {

        pear.SetActive(true);
        
        isMove = true;
        

        FindObjectOfType<AudioManager>().Play("Whoop");

        float duration = (float)1.2;

        yield return new WaitForSeconds(duration);
        isMove = false;
        FindObjectOfType<AudioManager>().Play("Glass Break");
        

    }

    //reveal passcode can and move it
    IEnumerator PasscodeCan()
    {

        yield return new WaitForSeconds(2);
        passcode.SetActive(true);
        isMove = true;


        FindObjectOfType<AudioManager>().Play("Vendy Jingle");

        float duration = (float)1.2;

        yield return new WaitForSeconds(duration);
        isMove = false;

    }

    //reveal orange can and move it
    IEnumerator OrangeCan()
    {

        orange.SetActive(true);
        isMove = true;


        FindObjectOfType<AudioManager>().Play("Whoop");

        float duration = (float)1.2;

        yield return new WaitForSeconds(duration);
        isMove = false;
        FindObjectOfType<AudioManager>().Play("Explode");
    }
}
