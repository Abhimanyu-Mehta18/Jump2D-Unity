using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 speed = new Vector2(10, 0);
    public float jumpForce = 4;
    public AudioSource src;

    bool isGrounded;

    void FixedUpdate()
    {
        rb.AddForce(speed);
    }
    public void Jump()
    {
        if (transform.position.y <= -3.60f)
        {
            src.Play();
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}

