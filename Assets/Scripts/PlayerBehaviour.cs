using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public float smooth;
    Rigidbody2D rb;
    Animator animator;
    private bool facingRight = true;
    private bool grounded;
    public Collider2D groundCheck;
    public LayerMask groundLayer;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        grounded = groundCheck.IsTouchingLayers(groundLayer);
        Debug.Log(grounded);
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }


    void FixedUpdate()
    {
        animator.SetBool("Jumping", !grounded);
        float xInput = Input.GetAxisRaw("Horizontal");
        Vector2 targetVelocity = new Vector2(xInput * speed, rb.velocity.y);
        rb.velocity = Vector2.SmoothDamp(rb.velocity, targetVelocity, ref targetVelocity, Time.deltaTime * smooth);
        if (xInput > 0 && !facingRight)
        {
            Flip();
        }
        else if(xInput < 0 && facingRight)
        {
            Flip();
        }
        animator.SetBool("Running", xInput != 0);
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
