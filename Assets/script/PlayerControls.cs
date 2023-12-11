using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody2D rb;

    public float jumpingPower; //for jump

    private bool isGrounded;    //for jump

    public Transform groundCheck;   //for jump

    public LayerMask groundLayer;   //for jump

    public Animator animator;

    public bool isJumping;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        HandleAnimation();

    }


    void PlayerMovement()
    {

        if (Input.GetButtonDown("Jump") && IsGrounded() && !isJumping) //if button hit and is player grounded
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower); //jump
            isJumping = true;
        }
        if (IsGrounded() && rb.velocity.y == 0)
        {
            isJumping = false;
        }
 
    }



    void HandleAnimation()
    {

        animator.SetBool("isJumping", isJumping);

    }




    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

}