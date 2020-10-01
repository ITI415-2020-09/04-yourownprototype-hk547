using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorFl1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 26, 0) * Time.deltaTime);
    }
}

