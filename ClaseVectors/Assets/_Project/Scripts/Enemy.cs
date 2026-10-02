using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData2[] dataArray;
    private int currentHealth;
    private EnemyData2 currentEnemy;

    void Start()
    {
        currentEnemy = GenerateRnd();
		currentHealth = currentEnemy.maxHealth;
		GetComponent<SpriteRenderer>().color = currentEnemy.color;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentEnemy.speed * Time.deltaTime);
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public EnemyData2 GenerateRnd()
    {
        int index = Random.Range(0, dataArray.Length);
        return dataArray[index];
    }
}