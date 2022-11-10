using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private MonoBehaviour CurrentState;
    public MonoBehaviour Idle;
    public MonoBehaviour Moving;
    public MonoBehaviour stun;
    void Start()
    {
        CurrentState = Idle;
        ActivateState(Idle);
    }

    public void ActivateState(MonoBehaviour newstate)
    {
        if (CurrentState != null)
        {
            CurrentState.enabled = false;
            CurrentState = newstate;
            CurrentState.enabled = true;
        }
    }
}
