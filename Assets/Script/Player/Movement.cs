using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public float sprintMultiplier; // The multiplier for sprint speed (40% faster)
    public Rigidbody2D rigidbody; // Use the 'new' keyword to hide the inherited member
    private Vector3 moveDirection;

    public ParticleSystem dust;

    void Start()
    {
        
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
        float moveZ = Input.GetAxisRaw("z"); // Tambahkan input untuk sumbu Z (Depth)

        moveDirection = new Vector3(moveX, 0, moveZ).normalized; // Menggunakan Vector3 untuk semua tiga sumbu
    }

    void Move()
    {
        float currentMoveSpeed = moveSpeed;

        // Terapkan multiplier sprint jika diperlukan
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentMoveSpeed *= sprintMultiplier;
        }

        rigidbody.velocity = moveDirection * currentMoveSpeed;
    }
}
