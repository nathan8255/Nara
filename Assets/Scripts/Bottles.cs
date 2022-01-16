using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottles : MonoBehaviour
{
    public InteractableObject mixerScript;
    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject purple;

    void Start()
    {
        red.SetActive(false);
        blue.SetActive(false);
        green.SetActive(false);
        purple.SetActive(false);
    }

    void Update()
    {
        if (!mixerScript.locked1)
        {
            red.SetActive(true);
            blue.SetActive(true);
            green.SetActive(true);
            purple.SetActive(true);
        }
    }
}
