using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondFloorTriggerScript : MonoBehaviour
{
    public bool ObjectInSecondFloorArea;
    void OnTriggerEnter(Collider other)
    {
        ObjectInSecondFloorArea = true;
    }
}
