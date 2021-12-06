using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
  public HealthBar healthBar;
  public int score = 0;

  public float moveSpeed;
  public Rigidbody2D rb;
  private Vector2 moveDirection;

  public Transform shootingPoint;
  public GameObject bulletPrefab;

  void Start()
  {
    ProcessInputs();
  }

  void Update()
  {
    if (Input.GetKeyDown("space"))
    {
      Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
    }
    ProcessInputs();
  }

  void FixedUpdate()
  {
    Move();
  }

  void ProcessInputs()
  {
    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    moveDirection = new Vector2(moveX, moveY).normalized;
  }

  void Move()
  {
    rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
  }

  // private void OnTriggerEnter2D(Collider2D collision)
  // {
  //   if (collision.tag == "Enemy")
  //   {
  //     explosionSoundEffect.Play();
  //     Destroy(gameObject, 0.5f);
  //     anim.Play("Explosion");
  //   }
  // }
  private void OnTriggerStay2D(Collider2D collision)
  {
    if (collision.tag == "Enemy")
    {
      healthBar.Damage(0.002f);
    }
  }
  // private void endGame()
  // {
  //   if (Health.totalHealth <= 0)
  //   {
  //     SceneManagement.LoadScene("End Scene");
  //   }
  // }
}
