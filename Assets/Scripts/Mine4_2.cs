using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine4_2 : MonoBehaviour
{
    public float speed = 2.5f;
    public float leftAndRightEdge = 5f;



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
        Vector3 pos = this.gameObject.transform.localPosition;
        pos.z += speed * Time.deltaTime;
        transform.localPosition = pos;

        // change Direction
        if (pos.z < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move forward
        }
        else if (pos.z > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // move backward
        }

    }
}
