using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;

    public float jumpForce = 20f;

    float mx;
    // for checking grounded
    public Transform feet; 
    public LayerMask groundLayers;
    
    public AudionSource JumpSound; // Jump sound effect



    private void Update()
    { // general horizontal movement
        mx = Input.GetAxisRaw("Horizontal");
// checking for jump input and playing jump sound
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
            JumpSound.Play();
        }
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }

    void Jump()
    { // custom jump function
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }

    public bool IsGrounded()
    { // checks if player is on the ground to limit jumps to 1
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }

        return false;
    }
}
