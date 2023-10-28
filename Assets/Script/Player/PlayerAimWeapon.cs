using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerAimWeapon : MonoBehaviour
{
    public event EventHandler<OnShootEventArgs> OnShoot;
    public class OnShootEventArgs : EventArgs {
      public Vector3 gunEndPointPosition;
      public Vector3 shootPosition;
    }
    private Transform aimTransform;
    private Transform aimGunEndPointTransform;
    private Animator aimAnimator;
    
    private void Awake()
    {
      aimTransform = transform.Find("Aim2");
      aimAnimator = aimTransform.GetComponent<Animator>();
      aimGunEndPointTransform = aimTransform.Find("GunEndPointPosition");
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
        UseClass useClass = GetComponent<UseClass>();
        Vector3 mousePosition = useClass.GetMouseWorldPosition();
        aimAnimator.SetTrigger("Shoot");
        OnShoot?.Invoke(this, new OnShootEventArgs {
            gunEndPointPosition = aimTransform.position,
            shootPosition = mousePosition
            }); 
      Debug.DrawLine(aimTransform.position, mousePosition, Color.red, 1.0f);
      }
    }
}
