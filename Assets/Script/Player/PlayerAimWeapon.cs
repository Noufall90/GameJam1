using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform aimTransform;
    private Animator aimAnimator;
    
    private void Awake()
    {
      aimTransform = transform.Find("Aim2");
      aimAnimator = aimTransform.GetComponent<Animator>();
    }

    private void Update(){
      HandleAiming();
      HandleShooting();
    }

    // Update is called once per frame
    private void HandleAiming()
    {
      UseClass useClass = GetComponent<UseClass>();
      Vector3 mousePosition = useClass.GetMouseWorldPosition();
    }

    private void HandleShooting(){
      if (Input.GetMouseButtonDown(0)){
        aimAnimator.SetTrigger("Shoot");
      }
    }
}
