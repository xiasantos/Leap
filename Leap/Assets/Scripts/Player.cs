using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 jumpHeight;
    public float playerSpeed;
    public Animator frogAnimator;
    // public AnimatorProvider x;
    public AudioSource dieSound;
    public AudioSource crunchSound;

    private Vector2 playerDirection;
    private bool gameRuning;
    private bool jumped;

    private void OnEnable()
    {
        StartGame.GameStarted += OnStartGame;
    }

    private void OnDisable()
    {
        StartGame.GameStarted -= OnStartGame;
    }

    private void OnStartGame()
    {
        gameRuning = true;
        rb.gravityScale = 5.0f;
    }

    private void Awake()
    {
        rb.gravityScale = 0.0f;
        //  frogAnimator = x.y;
    }

    void Update()
    {
        if (!gameRuning)
        {
            return;
        }

        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(directionX, directionY).normalized;

        if (Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.UpArrow))
        {
            jumped = true;
            frogAnimator.SetBool("Jump", jumped);
        }

    }


    void FixedUpdate()
    {
        if (!gameRuning)
        {
            return;
        }

        if (jumped)
        {
            rb.AddForce(jumpHeight, ForceMode2D.Force);
            jumped = false;
            frogAnimator.SetBool("Jump", jumped);
        }

        var speedX = playerDirection.x * playerSpeed;
        var speedY = Mathf.Clamp(rb.velocity.y, 0.0f, 100.0f);
        rb.velocity = new Vector2(speedX, speedY);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            crunchSound.Play();
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            dieSound.Play();
        }
    }
}
