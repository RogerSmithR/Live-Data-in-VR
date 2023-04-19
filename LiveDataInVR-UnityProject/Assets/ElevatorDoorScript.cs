using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorScript : MonoBehaviour
{
    //REQUEST AREAS
    public GameObject FirstFloorRequestArea;
    public GameObject SecondFloorRequestArea;

    //MOVE ASCENSOR
    public Transform AscensorPointFirstFloor;
    public Transform AscensorPointSecondFloor;
    public Transform Ascensor;

    //DOORS
    public Transform FirstFloorDoors;
    public Transform SecondFloorDoors;

    public float smoothTime = 0.3F;
    public float speed = 1.0f;

    private Vector3 velocity = Vector3.zero;
    bool IsDoorOpen = false;
    bool RequestOpenFirstFloor;
    bool RequestOpenSecondFloor;

    void Update()
    {
        RequestOpenFirstFloor = (bool)FirstFloorRequestArea.GetComponent<FirstFloorTriggerScript>().ObjectInFirstFloorArea;
        RequestOpenSecondFloor = (bool)SecondFloorRequestArea.GetComponent<SecondFloorTriggerScript>().ObjectInSecondFloorArea;
        if (RequestOpenFirstFloor)
        {
            //Debug.Log("Request at first floor");
            //TAKE DOWN THE ELEVATOR
            if (!IsDoorOpen)
            {
                if (Ascensor.position != AscensorPointFirstFloor.position)
                {
                    Ascensor.position = Vector3.SmoothDamp(Ascensor.position, AscensorPointFirstFloor.position, ref velocity, smoothTime);
                }
                else
                {
                    //CLOSE DOORS AFTER 5 SECONDS
                    StartCoroutine(OpenAndCloseDoorFirstFloor(FirstFloorDoors));
                }
            }
        }
        else if (RequestOpenSecondFloor)
        {
            //Debug.Log("Request at second floor");
            //TAKE UP THE ELEVATOR
            if (!IsDoorOpen)
            {
                if (Ascensor.position != AscensorPointSecondFloor.position)
                {
                    Ascensor.position = Vector3.SmoothDamp(Ascensor.position, AscensorPointSecondFloor.position, ref velocity, smoothTime);
                }
                else
                {
                    //CLOSE DOORS AFTER 5 SECONDS
                    StartCoroutine(OpenAndCloseDoorSecondFloor(SecondFloorDoors));
                }
            }
        }
        else
        {
            //Debug.Log("None request");
            CloseDoor(FirstFloorDoors);
            CloseDoor(SecondFloorDoors);
        }
    }

    IEnumerator OpenAndCloseDoorFirstFloor(Transform source)
    {
        OpenDoor(source);
        yield return new WaitForSeconds(5);
        CloseDoor(FirstFloorDoors);
        FirstFloorRequestArea.GetComponent<FirstFloorTriggerScript>().ObjectInFirstFloorArea = false;
    }

    IEnumerator OpenAndCloseDoorSecondFloor(Transform source)
    {
        OpenDoor(source);
        yield return new WaitForSeconds(5);
        SecondFloorRequestArea.GetComponent<SecondFloorTriggerScript>().ObjectInSecondFloorArea = false;
    }

    void OpenDoor(Transform source)
    {
        Transform leftDoor = source.Find("LeftDoor");
        Transform LeftDestinationPoint = source.Find("LeftDestinationPoint");

        Transform rightDoor = source.Find("RightDoor");
        Transform RightDestinationPoint = source.Find("RightDestinationPoint");

        if (leftDoor.position == LeftDestinationPoint.position && rightDoor.position == RightDestinationPoint.position)
        {
            IsDoorOpen = true;
        }
        else
        {
            MoveTowardsTarget(leftDoor, LeftDestinationPoint, 0.2f);
            MoveTowardsTarget(rightDoor, RightDestinationPoint, 0.2f);
        }
    }

    void CloseDoor(Transform source)
    {
        Transform leftDoor = source.Find("LeftDoor");
        Transform leftOriginPoint = source.Find("LeftOriginPoint");

        Transform rightDoor = source.Find("RightDoor");
        Transform rightOriginPoint = source.Find("RightOriginPoint");

        if (leftDoor.position == leftOriginPoint.position && rightDoor.position == rightOriginPoint.position)
        {
            IsDoorOpen = false;
        }
        else
        {
            MoveTowardsTarget(leftDoor, leftOriginPoint, 0.2f);
            MoveTowardsTarget(rightDoor, rightOriginPoint, 0.2f);
        }
    }

    void MoveTowardsTarget(Transform source, Transform destination, float smoothTime)
    {
        if (source.position != destination.position)
        {
            float step = speed * Time.deltaTime; // calculate distance to move
            source.position = Vector3.MoveTowards(source.position, destination.position, step);
        }
    }
}