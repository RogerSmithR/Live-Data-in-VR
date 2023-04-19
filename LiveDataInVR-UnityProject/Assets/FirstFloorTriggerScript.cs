using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorTriggerScript : MonoBehaviour
{
    public bool ObjectInFirstFloorArea;
    void OnTriggerEnter(Collider other)
    {
        ObjectInFirstFloorArea = true;
    }
}
