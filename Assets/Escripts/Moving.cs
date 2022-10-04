using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moving : MonoBehaviour
{
    public Navigation_Controller nav;
    public StateMachine state;
    public Idle Idle;
    void OnEnable()
    {
        Debug.Log("Current State: Idle");
        SendMessage("updateDestination");
    }

    void Update()
    {
        if (nav.hasItArrived() <= 1)
        {
            nav.stopMoving();
            state.ActivateState(Idle);
        }
    }
}
