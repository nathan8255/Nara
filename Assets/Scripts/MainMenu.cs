using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //https://www.youtube.com/watch?v=zc8ac_qUXQY&ab_channel=Brackeys

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
