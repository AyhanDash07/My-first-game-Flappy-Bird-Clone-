using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -10;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe is deleted!");
            Destroy(gameObject);
        }
    }
}
