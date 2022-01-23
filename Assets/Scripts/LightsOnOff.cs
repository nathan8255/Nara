using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//turns the lights on and off in barabar
public class LightsOnOff : MonoBehaviour
{
    public GameObject lightsOff;
    public GameObject writing;

    
    public void TurnLightsOn()
    {
        writing.SetActive(false);
        lightsOff.SetActive(false);
        
        
    }

    public void TurnLightsOff()
    {
        writing.SetActive(true);
        lightsOff.SetActive(true);
        
    }
}
