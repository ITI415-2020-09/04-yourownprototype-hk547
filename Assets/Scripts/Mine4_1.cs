using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine4_1 : MonoBehaviour
{
    public float speed = 2.5f;
    public float leftAndRightEdge = 3.5f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // basic movement 
        // current position of mine
        // time based not frame
        // move to new position
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // change Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // move left
        }

    }
}
