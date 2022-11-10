using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moving : MonoBehaviour
{
    public Navigation_Controller nav;
    public MonoBehaviour Stu;
    public StateMachine state;
    public Idle Idle;
    void OnEnable()
    {
        Debug.Log("Current State: Moving");
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

    void Stun()
    {
        nav.stopMoving();
        transform.SendMessage("ActivateState", Stu);
    }
}
