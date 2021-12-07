using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
  public float speed;
  private float lifetime;

  private Animator anim;
  [SerializeField] private AudioSource explosionSoundEffect;

  void Start()
  {
    anim = GetComponent<Animator>();
  }

  void Update()
  {

    transform.Translate(Vector3.up * -1 * speed * Time.deltaTime);

    lifetime += Time.deltaTime;
    // if (lifetime > 4) gameObject.SetActive(false);
    if (lifetime > 10) Destroy(gameObject);

  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Bullet")
    {

      explosionSoundEffect.Play();
      Destroy(gameObject, 0.5f);
      anim.Play("Explosion");
    }
    else if (collision.tag == "Player")
    {
      explosionSoundEffect.Play();
      Destroy(gameObject, 0.5f);
      anim.Play("Explosion");
    }
  }

  private void ResetLifetime()
  {
    lifetime = 0;
  }
}
