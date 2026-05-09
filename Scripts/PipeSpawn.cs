using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawn : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 4.5f;
    private float timer = 0;
    public float height = 2.5f;
    
    void Start()
    {
        spawnPipe();
    }

    
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;   
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - height;
        float highestPoint = transform.position.y + height;

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
