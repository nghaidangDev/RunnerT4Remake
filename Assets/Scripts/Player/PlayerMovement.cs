using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private Animator anim;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask layer;

    private Rigidbody2D rb;

    [SerializeField] private AudioClip jumpSound;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            AudioManager.instance.PlaySound(jumpSound);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.SetTrigger("jump");
        }
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.5f, layer);
    }
}
