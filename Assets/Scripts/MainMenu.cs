using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("ConvenienceStore");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Barabar");
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}
