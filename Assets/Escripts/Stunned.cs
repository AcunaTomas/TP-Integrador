using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stunned : MonoBehaviour
{
    public MonoBehaviour Idle;

    void OnEnable()
    {
        Debug.Log("Current State: Stunned");
    }
    void Start()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        transform.SendMessage("ActivateState", Idle);
    }
}
