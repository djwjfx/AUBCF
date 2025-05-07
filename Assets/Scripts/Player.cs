using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    public float jumpForce;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer sprite;
    bool isGrounded;
    float x, y;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector3.down, 2f, LayerMask.GetMask("Ground"));
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x, y, 0) * speed * Time.deltaTime;
        animator.SetBool("Move", (x != 0 || y != 0));

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

        if (x != 0)
        {
            sprite.flipX = (x > 0) ? false : true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector3.down);
    }
}
