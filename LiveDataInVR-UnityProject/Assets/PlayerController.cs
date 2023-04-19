using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destination;
    public bool GenerateRandom = true;

    void Start()
    {
        UpdateDestination();
    }

    public Vector3 point;
    public float range = 1000.0f;

    void Update()
    {
        if (point.x == transform.position.x && point.z == transform.position.z)
        {
            UpdateDestination();
        }
    }

    bool RandomPoint(Vector3 center, float range)
    {
        if (GenerateRandom)
        {
            var randomPoint = new Vector3(Random.Range(12.5f, 48.55f), Random.Range(1.5f, 16f), Random.Range(0, 54f));
            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
            {
                point = hit.position;
                return true;
            }
            point = Vector3.zero;
            return false;
        }
        else
        {
            point = destination.position;
            return true;

            //NavMeshHit hit;
            //if (NavMesh.SamplePosition(destination.position, out hit, 1.0f, NavMesh.AllAreas))
            //{
            //    point = hit.position;
            //    return true;
            //}
            //point = Vector3.zero;
            //return false;
        }
    }

    void UpdateDestination()
    {
        if (RandomPoint(transform.position, range))
        {
            agent.SetDestination(point);
        }
        else
        {
            UpdateDestination();
        }
    }
}
