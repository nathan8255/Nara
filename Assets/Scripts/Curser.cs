using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curser : MonoBehaviour
{

    public Texture2D capyPaw;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(capyPaw, Vector2.zero, CursorMode.ForceSoftware);
    }
}
