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

  void Update()
  {
    lifetime += Time.deltaTime;
    if (lifetime > 4) Destroy(gameObject);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Enemy")
      Destroy(gameObject);
  }

  private void ResetLifetime()
  {
    lifetime = 0;
  }
}
