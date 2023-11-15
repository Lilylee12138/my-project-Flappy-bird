using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapstrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive )//aka. if( Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
           rb.velocity = Vector2.up * flapstrength; 
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();//when the bird collide the pipe, then game over
        birdIsAlive = false;
    }


}
