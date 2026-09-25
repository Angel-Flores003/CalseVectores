using UnityEngine;

public class Coin : MonoBehaviour
{
    public int points = 5;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(points);
            Destroy(gameObject);
        }
    }
}
