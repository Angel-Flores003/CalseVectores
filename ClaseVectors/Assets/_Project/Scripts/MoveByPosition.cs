using UnityEngine;

public class MoveByPosition : MonoBehaviour
{
    private float speed = 3;

    void Start()
    {

    }

    void Update()
    {
        Vector3 movement = new Vector3(speed, 0f, 0f);
        transform.position += movement * Time.deltaTime;
    }
}