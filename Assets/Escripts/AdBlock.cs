using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdBlock : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(a());
    }

    void Update()
    {
        transform.localScale += new Vector3(11 * Time.deltaTime, 11 * Time.deltaTime,11 * Time.deltaTime);
    }

    IEnumerator a()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bicho"))
        {
            other.SendMessage("Stun");
        }
    }
}
