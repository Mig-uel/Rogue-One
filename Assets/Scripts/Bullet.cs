using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
  private Rigidbody2D rb;
  private float lifetime;

  public EnemyController enemy;
  public EnemyController enemy1;
  public EnemyController enemy2;
  public EnemyController enemy3;

  public float speed;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = transform.up * speed;

    enemy = GameObject.FindWithTag("Enemy-1").GetComponent<EnemyController>();

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
      enemy = GameObject.FindWithTag("Enemy-1").GetComponent<EnemyController>();
      enemy.TakeHit(1.5f);
    }
    else if (collision.tag == "Enemy-2")
    {
      enemy = GameObject.FindWithTag("Enemy-2").GetComponent<EnemyController>();
      enemy.TakeHit(1f);
    }
    else if (collision.tag == "Enemy-3")
    {
      enemy = GameObject.FindWithTag("Enemy-3").GetComponent<EnemyController>();
      enemy.TakeHit(2.5f);
    }
    Destroy(gameObject);
  }

  private void ResetLifetime()
  {
    lifetime = 0;
  }
}
