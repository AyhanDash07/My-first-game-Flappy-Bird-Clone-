using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrenght;
    public LogicScript Logic;
    public bool birdIsAlive = true;
    
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrenght;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameOver();
        birdIsAlive = false;
    }
}
