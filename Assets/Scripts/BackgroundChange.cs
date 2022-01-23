using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    public GameObject trigger;
    public GameObject currentBack;
    public GameObject newBack;
    public GameObject newInteraction;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            trigger.SetActive(false);
            currentBack.SetActive(false);
            newBack.SetActive(true);
            newInteraction.SetActive(true);
            if (trigger.name.Equals("Break"))
            {
                FindObjectOfType<AudioManager>().Play("Glass Break");
            }
        }
    }

    
}
