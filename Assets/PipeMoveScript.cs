using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        //for those pipes which are off screen and do nothing, then delete them 
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pip Deleted");
            Destroy(gameObject);
        }
    }
}
