using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {

            transform.position += new Vector3(-4f * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("d"))
        {

            transform.position += new Vector3(4f * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("s"))
        {

            transform.position += new Vector3(0, 0, -4f * Time.deltaTime);

        }
        if (Input.GetKey("w"))
        {

            transform.position += new Vector3(0, -0,4f * Time.deltaTime);

        }
    }
}
