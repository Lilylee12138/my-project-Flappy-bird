using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScripe : MonoBehaviour
{
    public LogicScript logic;


    // Start is called before the first frame update
    void Start()
    {
        //help the code to find the LogicScript
        //as soon as a new pipe spawns, it will look through the hierarchy to find a GameObject with tag "Logic"
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //when the bird collide the middle pipe, the add score
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);  
        }
       
    }
}
