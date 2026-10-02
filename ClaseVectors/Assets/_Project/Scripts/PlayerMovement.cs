using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;
using static UnityEngine.UI.Image;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    public float rayLength = 0.6f;
    public LayerMask groundLayer;
    public Transform coin;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // -1, 0 or 1
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);//al ponerle 0 a la velocidad vertical, el jugador no puede saltar

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        // To see it: start, direction * length, color
        Debug.DrawRay(transform.position, Vector2.down * rayLength, Color.red);
    }

    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayLength, groundLayer);
        
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.name);
        }
        
        return hit;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}