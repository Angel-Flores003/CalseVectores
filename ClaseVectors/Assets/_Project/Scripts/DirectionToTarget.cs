using UnityEngine;

public class DirectionToTarget : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        
    }

    void Update()
    {
		Debug.Log((target.position - transform.position).sqrMagnitude);
		Debug.DrawLine(transform.position, target.position, Color.cyan);
	}
}