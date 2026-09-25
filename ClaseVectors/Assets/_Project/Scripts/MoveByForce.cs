using UnityEngine;

public class MoveByForce : MonoBehaviour
{
    private int force = 3;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(force, 0f));
    }
}