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

    void Start()
    {
        pear.SetActive(false);
        passcode.SetActive(false);
        banana.SetActive(false);
        orange.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (!vendyScript.locked1)
        {
            banana.SetActive(true);
        }
        if (!vendyScript.locked2)
        {
            pear.SetActive(true);
            passcode.SetActive(true);
        }
        if (!vendyScript.locked3)
        {
            orange.SetActive(true);
        }
    }
}
