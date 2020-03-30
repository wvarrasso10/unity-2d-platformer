using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool slash = false;

// Update is called once per frame
void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Vertical"))
        {
            slash = true;
            animator.SetBool("isAttack", slash);
        }
        else if(Input.GetButtonUp("Vertical"))
        {
            slash = false;
            animator.SetBool("isAttack", slash);
        }

    }
    void FixedUpdate()
    {
        //move the character
        controller.Move(horizontalMove*Time.fixedDeltaTime, false, jump);
        
        jump = false;
    }
}
