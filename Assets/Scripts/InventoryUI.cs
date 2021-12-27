using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
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
