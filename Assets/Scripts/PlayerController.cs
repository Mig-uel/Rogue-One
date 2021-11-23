using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Animator anim;
  [SerializeField] private AudioSource explosionSoundEffect;

  public float moveSpeed;
  public Rigidbody2D rb;
  private Vector2 moveDirection;

  void Start()
  {
    ProcessInputs();
    anim = GetComponent<Animator>();
  }

  void Update()
  {
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
    if (collision.tag == "Enemy")
    {
      explosionSoundEffect.Play();
      Destroy(gameObject, 0.5f);
      anim.Play("Explosion");
    }
  }
}
