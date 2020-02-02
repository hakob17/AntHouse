using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 500f;
    public Animator anim;
    private bool isGrounded = true;

    public KeyCode jumpKey;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            anim.Play("jump");
            GetComponent<BoxCollider2D>().size = new Vector2(2,5);
            GetComponent<Rigidbody2D>().AddForce(jumpForce * Vector2.up);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            if (!isGrounded)
            {
                anim.Play("land");
                GetComponent<BoxCollider2D>().size = new Vector2(2,4);
            }
            isGrounded = true;
        }
    }
}