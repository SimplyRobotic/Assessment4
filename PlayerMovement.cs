using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;

    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;

    float mx;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

  // simple movement left/right
    void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }
    }
    
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }
    // jump function
    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }
    //checks grounded to limit jumps to one
   public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if(groundCheck.gameObject != null)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
}
