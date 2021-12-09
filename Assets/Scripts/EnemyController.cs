using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
  public Score score2;

  public float speed;
  private float lifetime;

  public float HitPoints;
  public float MaxHitPoints = 5;

  private Animator anim;
  [SerializeField] private AudioSource explosionSoundEffect;

  void Start()
  {
    anim = GetComponent<Animator>();
    HitPoints = MaxHitPoints;
    score2 = GameObject.FindWithTag("GameManager").GetComponent<Score>();
  }

  void Update()
  {
    transform.Translate(Vector3.up * -1 * speed * Time.deltaTime);

    lifetime += Time.deltaTime;

    if (lifetime > 10) Destroy(gameObject);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Bullet")
    {
      if (HitPoints <= 0)
      {
        explosionSoundEffect.Play();
        Destroy(gameObject, 0.5f);
        anim.Play("Explosion");
        score2.addScore(10);
      }
    }
    else if (collision.tag == "Player")
    {
      explosionSoundEffect.Play();
      Destroy(gameObject, 0.5f);
      anim.Play("Explosion");
      score2.subScore(5);
    }
  }

  public void TakeHit(float damage)
  {
    HitPoints -= damage;

    // if (HitPoints <= 0)
    // {
    //   explosionSoundEffect.Play();
    //   Destroy(gameObject);
    //   anim.Play("Explosion");
    // }
  }

  private void ResetLifetime()
  {
    lifetime = 0;
  }
}
