using UnityEngine;

public class MoveByVelocity : MonoBehaviour
{
    private int speed = 3;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(speed, 0f);
    }
}