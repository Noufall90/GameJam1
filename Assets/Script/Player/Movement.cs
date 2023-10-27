using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public float sprintMultiplier;
    public new Rigidbody rigidbody; // Mengganti Rigidbody2D menjadi Rigidbody
    private Vector3 moveDirection;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Mendapatkan input dari pemain
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Menghitung vektor arah berdasarkan input (mengubah sumbu Y ke Z)
        moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float currentMoveSpeed = moveSpeed;

        // Terapkan multiplier sprint jika diperlukan
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentMoveSpeed *= sprintMultiplier;
        }

        // Mengatur kecepatan rigidbody berdasarkan input (mengubah sumbu Y ke Z)
        rigidbody.velocity = moveDirection * currentMoveSpeed;
    }
}
