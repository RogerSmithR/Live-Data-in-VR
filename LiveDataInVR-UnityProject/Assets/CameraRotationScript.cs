using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationScript : MonoBehaviour
{
    public GameObject TargetObject;
    public GameObject ligth;

    void Update()
    {
        if (TargetObject != null)
        {
            transform.LookAt(TargetObject.transform);
            ligth.SetActive(true);
        }
        else
        {
            ligth.SetActive(false);
        }
    }
}
