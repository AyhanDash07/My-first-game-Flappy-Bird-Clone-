using UnityEngine;

public class MiddleTrigger : MonoBehaviour
{
    public LogicScript Logic;
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Logic.AddScore(1);
        }
        
    }
}
