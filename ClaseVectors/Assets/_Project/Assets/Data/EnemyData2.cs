using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData2", menuName = "Scriptable Objects/EnemyData2")]
public class EnemyData2 : ScriptableObject
{
	public string enemyName;
	public int maxHealth;
	public int damage;
	public float speed;
	public Color color;
}
