using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovement : MonoBehaviour
{
  private Vector3 startPosition;
  private Vector3 roamPosition;

  public static Vector3 GetRandomDir()
  {
    Vector3 randomDirection = new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f));
    return randomDirection.normalized;
  }

  private void Start()
  {
    startPosition = transform.position;
  }
  private Vector3 GetRoamPosition()
  {
    return startPosition + GetRandomDir() * Random.Range(10f, 70f);
  }
}
