using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestTeletransportationScript : MonoBehaviour
{
    public GameObject RayInteractorObject;
    public GameObject ContinuosGameObjectRef;
    public GameObject HeadRigidBody;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "XR Origin")
        {
            RayInteractorObject.SetActive(true);
            HeadRigidBody.SetActive(true);
            ContinuosGameObjectRef.SetActive(false);
        }
    }
}
