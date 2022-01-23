using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //https://forum.unity.com/threads/how-to-flip-animation-in-2d.375921/ - flip
    //https://www.youtube.com/watch?v=ee3CQvi3Oqs&t=497s&ab_channel=MuddyWolf - movement

    public Rigidbody2D rb;
    public Animator animator;
    public float moveSpeed;
    public bool facingRight; //capy is facing right by default
    float horizontalMove = 0f;
    Vector2 movement;
    Scene currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        //if the player is currently in a dialogue interaction don't let them move capy around
        if (DialogueManager.isActive || FindObjectOfType<PlayerInteract>().ifPass )
        {
            return;
        }

        //checks which direction player is facing and flips appropriatly depending on which direction was pressed
        float h = Input.GetAxis("Horizontal");
        if (h > 0 && !facingRight) Flip();
        else if (h < 0 && facingRight) Flip();

        //figures out speed of capy and sets the "speed" parameter to said speed - decides whether the walking animation is played or not
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        MovementInput();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector2 theScale = transform.localScale;
        //setting the scale to -1 flips the character (keeps scale the same)
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void FixedUpdate()
    {
        //if the player is currently in a dialogue interaction, stop capy and don't let them move capy around
        //if dialogue is not active, and if the lights are off in barabar, stop capy from moving. otherwise, let capy move

        if (DialogueManager.isActive || FindObjectOfType<PlayerInteract>().ifPass)
        {
            rb.velocity = movement * 0;
            
        }
        else 
        {
            rb.velocity = movement * moveSpeed;
            if (currentScene.name.Equals("Barabar"))
            {
                if (FindObjectOfType<LightsOnOff>().lightsOff.activeSelf)
                {
                    rb.velocity = movement * 0;
                }
                else
                {
                    rb.velocity = movement * moveSpeed;
                }
            }
        }

       

        
        
        
    }

    void MovementInput()
    {
        //obtain the position player is moving capy towards via WASD or arrow keys
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        movement = new Vector2(mx, my).normalized;
    }
}
