using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorCameraAreaScript : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;

    void OnTriggerEnter(Collider other)
    {
        if (Camera1.GetComponent<CameraRotationScript>().TargetObject == null && other.gameObject.layer != LayerMask.NameToLayer("Gun"))
        {
            Camera1.GetComponent<CameraRotationScript>().TargetObject = other.gameObject;
        }
        else if (Camera2.GetComponent<CameraRotationScript>().TargetObject == null && other.gameObject.layer != LayerMask.NameToLayer("Gun"))
        {
            Camera2.GetComponent<CameraRotationScript>().TargetObject = other.gameObject;
        }
        else if (Camera3.GetComponent<CameraRotationScript>().TargetObject == null && other.gameObject.layer != LayerMask.NameToLayer("Gun"))
        {
            Camera3.GetComponent<CameraRotationScript>().TargetObject = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        OnExit(other.gameObject, Camera1);
        OnExit(other.gameObject, Camera2);
        OnExit(other.gameObject, Camera3);
    }

    void OnExit(GameObject target, GameObject camera)
    {
        GameObject actualTargetObject = camera.GetComponent<CameraRotationScript>().TargetObject;
        if (actualTargetObject != null && actualTargetObject.name == target.name)
        {
            camera.GetComponent<CameraRotationScript>().TargetObject = null;
        }
    }
}
