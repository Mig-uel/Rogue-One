using UnityEngine;

public class Shooting : MonoBehaviour
{
  public Transform shootingPoint;
  public GameObject bulletPrefab;
  void Update()
  {
    if (Input.GetKeyDown("space"))
    {
      Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
    }
  }
}
