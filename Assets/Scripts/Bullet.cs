using UnityEngine;

public class Bullet : MonoBehaviour
{
  private Rigidbody2D rb;
  private float lifetime;

  public float speed;
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = transform.up * speed;
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    Destroy(gameObject);
  }
}
