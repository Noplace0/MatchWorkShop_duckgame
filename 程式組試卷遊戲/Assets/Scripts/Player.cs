using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public float jumpAmount = 10;

    private void Start()
    {
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            rb.velocity = new Vector2(Speed * -1, rb.velocity.y);
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
            rb.velocity = new Vector2(Speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }

        var speed = rb.velocity.magnitude;
        animator.SetFloat("Speed", speed);
    }
}
