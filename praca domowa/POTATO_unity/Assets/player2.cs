using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float speed;
    public float jump;

    private Rigidbody2D rb;
    public bool isGrounded;
    public KeyCode left;
    public KeyCode right;
    public KeyCode jumping ;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        isGrounded = true;
        if (Input.GetKey(left))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKey(jumping) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);

        }

    }
}

