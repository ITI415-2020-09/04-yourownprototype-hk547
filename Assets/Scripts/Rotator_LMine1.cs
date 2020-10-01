using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator_LMine1 : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -65) * Time.deltaTime);
    }
}
