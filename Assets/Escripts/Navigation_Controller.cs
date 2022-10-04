using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation_Controller : MonoBehaviour
{
    public Transform trs;
    private UnityEngine.AI.NavMeshAgent nav;
    void Start()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        nav.isStopped = true;
    }

    public void updateDestination()
    {
        nav.destination =trs.position;
        nav.isStopped = false;
    }

    public float hasItArrived()
    {
        if (nav.destination != trs.position)
        {
            nav.destination = trs.position;
        }
        return Vector3.Distance(transform.position, trs.position);
    }

    public void stopMoving()
    {
        nav.isStopped = true;
    }
}
