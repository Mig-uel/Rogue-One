using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
  [SerializeField] float speed;
  private float lifetime;
  void Update()
  {
    transform.Translate(Vector3.up * -1 * speed * Time.deltaTime);

    lifetime += Time.deltaTime;
    // if (lifetime > 4) gameObject.SetActive(false);
    if (lifetime > 4) Destroy(gameObject);

  }
  private void ResetLifetime()
  {
    lifetime = 0;
  }
}
