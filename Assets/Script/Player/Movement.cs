using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public float sprintMultiplier = 1.4f; // The multiplier for sprint speed (40% faster)
    public Rigidbody2D rigidbody; // Use the 'new' keyword to hide the inherited member
    private Vector2 moveDirection;

    public ParticleSystem dust;

    // Start is called before the first frame update
    void Start()
    {
        // You can perform any initialization here if needed
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        // Check for sprinting input here if needed
    }

    void Move()
    {
        float currentMoveSpeed = moveSpeed;

        // Apply sprinting multiplier if needed
        // if (Input.GetKey(KeyCode.LeftShift))
        // {
        //     currentMoveSpeed *= sprintMultiplier;
        // }

        rigidbody.velocity = moveDirection * currentMoveSpeed;
    }
}
