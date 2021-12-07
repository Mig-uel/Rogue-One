using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
  private Rigidbody2D rb;
  private float lifetime;

  public Score score2;

  public float speed;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = transform.up * speed;

    score2 = GameObject.FindWithTag("GameManager").GetComponent<Score>();
  }

  void Update()
  {
    lifetime += Time.deltaTime;
    if (lifetime > 5) Destroy(gameObject);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Enemy-1")
    {
      Destroy(gameObject);
      score2.addScore(10);
    }
    else if (collision.tag == "Enemy-2")
    {
      Destroy(gameObject);
      score2.addScore(25);
    }
    else if (collision.tag == "Enemy-3")
    {
      Destroy(gameObject);
      score2.addScore(5);
    }
  }

  private void ResetLifetime()
  {
    lifetime = 0;
  }
}
