using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float MovementSpeed;
    public float jumpForce;

    private bool isGrounded = true;
    private Rigidbody2D rb;
    private Vector3 jump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay2D()
    {
        isGrounded = true;
    }

    void Update ()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * MovementSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * MovementSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
}
