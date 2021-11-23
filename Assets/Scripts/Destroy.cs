using UnityEngine;
using UnityEngine.SceneManagement;
public class Destroy : MonoBehaviour
{
  private Animator anim;
  [SerializeField] private AudioSource explosionSoundEffect;

  void Start()
  {
    anim = GetComponent<Animator>();
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    // Must create 2D sprite and tag it Bound
    // if (collision.gameObject.CompareTag("Bound"))
    // {
    //   gameObject.SetActive(false);
    // }
    explosionSoundEffect.Play();

    Destroy(gameObject, 0.5f);
    anim.Play("Explosion");
  }

  // private void OnCollisionEnter2D(Collision2D other)
  // {
  //   if (collision.tag == "Enemy")
  //   {

  //   }
  // }
}
