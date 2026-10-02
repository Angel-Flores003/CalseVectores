using System.Dynamic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SmartTurret : MonoBehaviour
{
	public Transform player;
	public GameObject bulletPrefab;
	public float visionRange = 10000f;
	public float bulletSpeed = 10f;
	public float timeBetweenShots = 1f;

	private float shootTimer = 0f;

	void Update()
	{
		Vector2 direction = (player.position - transform.position).normalized;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, visionRange);
		Debug.DrawRay(transform.position, direction * visionRange, Color.yellow);

		if (hit.collider != null && hit.collider.CompareTag("Player"))
		{
			var targetDirection = player.position - transform.position;
			float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
			transform.eulerAngles = new Vector3(0f, 0f, angle);

            // Time per shoot
            shootTimer += Time.deltaTime;
			if (shootTimer >= timeBetweenShots)
			{
				Shoot(direction);
				shootTimer = 0f;
			}
		}
	}
	void Shoot(Vector2 directon)
	{
		GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
		Rigidbody2D bulletrb = bullet.GetComponent<Rigidbody2D>();
		bulletrb.linearVelocity = directon * bulletSpeed;

        Destroy(bullet, 3f);
	}
}