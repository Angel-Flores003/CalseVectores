using UnityEngine;

public class VectorBasics : MonoBehaviour
{
    public Vector2 startPosition = new (2, 1);
    public Vector2 myVector = new (3, 4);
	void Start()
    {
        transform.position = startPosition;
		Debug.Log("Magnitude vector " + myVector.magnitude);
        Debug.Log("Normalized vector " + myVector.normalized);
	}

    void Update()
    {
        
    }
}