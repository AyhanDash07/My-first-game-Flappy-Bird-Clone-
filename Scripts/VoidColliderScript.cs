using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class VoidColliderScript : MonoBehaviour
{
    public GameObject GameOverScreen;
    public LogicScript Logic;
    public GameObject Bird;
    
    
    
    
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameOver();
        
    }

}

