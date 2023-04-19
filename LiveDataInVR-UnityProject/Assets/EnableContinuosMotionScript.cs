using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableContinuosMotionScript : MonoBehaviour
{
    public GameObject RayInteractorObject;
    public GameObject ContinuosGameObjectRef;
    public GameObject HeadRigidBody;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "XR Origin")
        {
            RayInteractorObject.SetActive(false);
            HeadRigidBody.SetActive(false);
            ContinuosGameObjectRef.SetActive(true);
        }
    }
}
