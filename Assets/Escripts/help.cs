using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help : MonoBehaviour
{
    public GameObject Imag;
    public bool a;

    void Start()
    {
        a = true;
    }

    public void show()
    {
        Imag.SetActive(a);
        a = !a;
    }
}
