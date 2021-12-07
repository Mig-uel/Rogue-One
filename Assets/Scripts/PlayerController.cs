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

  private Score score1;

  void Start()
  {
    ProcessInputs();

    score1 = GameObject.FindWithTag("GameManager").GetComponent<Score>();
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

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Enemy-1" || collision.tag == "Enemy-2" || collision.tag == "Enemy-3")
    {
      score1.subScore();
    }
  }
  private void OnTriggerStay2D(Collider2D collision)
  {
    if (collision.tag == "Enemy-1")
    {
      healthBar.Damage(0.004f);
    }
    else if (collision.tag == "Enemy-2")
    {
      healthBar.Damage(0.006f);
    }
    else if (collision.tag == "Enemy-3")
    {
      healthBar.Damage(0.002f);
    }

    if (Health.totalHealth <= 0)
    {
      SceneManager.LoadScene(4);
    }
  }
}
