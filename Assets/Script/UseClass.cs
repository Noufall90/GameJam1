using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseClass : MonoBehaviour
{
     [SerializeField] private float rotationSpeed = 5f; // Kecepatan rotasi pistol
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     // GetMouseWorldPosition();
    }

    public Vector3 GetMouseWorldPosition(){
        Vector3 mousePosition = Input.mousePosition; 
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z));
        Vector3 direction = worldPosition - transform.parent.position;

        // Hitung sudut rotasi berdasarkan arah
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotasi pistol
        transform.localRotation = Quaternion.Euler(0, 0, angle);
        // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, angle), rotationSpeed * Time.deltaTime);
        // Debug.Log("Mouse Position (World): " + worldPosition);
        return worldPosition;
    }
}
