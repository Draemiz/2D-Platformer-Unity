using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rd;
    public float speed = 5f;
    public float jumpforce = 7f;
    private Animator animator;
    private bool isGrounded;
    private bool facinRight = true;
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
{
    float move = Input.GetAxis("Horizontal");

    float speedAnimation = Mathf.Abs(move);

    animator.SetFloat("Speed", speedAnimation);

    rd.velocity = new Vector2(move * speed, rd.velocity.y);

    if (move > 0 && !facinRight){
        Flip();
    }else if (move < 0 && facinRight){
        Flip();
    }

    // Salto
    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    {
        rd.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);

        isGrounded = false;
        animator.SetBool("isJump", true);
    }
}
    void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("isJump", false);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    void Flip()
    {
        facinRight = !facinRight;
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }
}
