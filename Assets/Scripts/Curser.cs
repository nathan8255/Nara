using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curser : MonoBehaviour
{

    public Texture2D capyPaw;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1280, 720, false);
        Cursor.SetCursor(capyPaw, Vector2.zero, CursorMode.ForceSoftware);
    }
}
