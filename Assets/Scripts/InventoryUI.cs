using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    //https://www.youtube.com/watch?v=gGUtoy4Knnw&list=PLa5_l08N9jzM7s58ly3K5ZXYypX8AyWiS&ab_channel=ScriptingIsFun

    public GameObject inventory;
    public Animator anim;

    void Awake()
    {
        anim.SetBool("MouseOver", false);
    }

    void OnMouseOver()
    {
        anim.SetBool("MouseOver", true);
        Debug.Log("mouse over");
    }

    void OnMouseExit()
    {
        anim.SetBool("MouseOver", false);
        Debug.Log("mouse exit");
    }
}
