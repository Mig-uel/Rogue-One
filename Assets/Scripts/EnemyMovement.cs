using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
  [SerializeField] float speed;
  void Update()
  {
    transform.Translate(Vector3.up * -1 * speed * Time.deltaTime);
  }
}
