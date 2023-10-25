using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate: MonoBehaviour
{
    public Transform cameraTransform; // Atur transform kamera Anda di Inspector

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Putar kamera sebesar 30 derajat sekitar sumbu y (vertikal)
            cameraTransform.Rotate(Vector3.up, 30f);
        }
    }
}
