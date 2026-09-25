using Unity.VisualScripting;
using UnityEngine;

public class TurrentAim : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        
    }

	void Update()
    {
        var targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0f, 0f, angle);
	}
}