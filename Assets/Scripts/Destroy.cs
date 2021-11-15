using UnityEngine;
using UnityEngine.SceneManagement;
public class Destroy : MonoBehaviour
{
  private Animator anim;
  [SerializeField] private AudioSource explosionSoundEffect;
  // private GameObject enemy;
  void Start()
  {
    anim = GetComponent<Animator>();
    // enemy = GameObject.FindWithTag("Enemy");
  }
  // private void OnCollisionEnter2D(Collision2D other)
  // {
  //   Destroy(gameObject, 0.5f);
  // }
  private void OnTriggerEnter2D(Collider2D collision)
  {

    if (collision.gameObject.CompareTag("Bound"))
    {
      gameObject.SetActive(false);
    }

    explosionSoundEffect.Play();

    Destroy(gameObject, 0.5f);
    anim.Play("Explosion");
  }
}