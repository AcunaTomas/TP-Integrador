using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    public int charges;
    public GameObject ball;
    public GameObject gover;
    public GameObject winner;
    public TextMeshProUGUI text;
    private float waitingtime;
    private bool isReady;
    void Start()
    {
        waitingtime = 0.5f;
        isReady = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bicho"))
        {
            lose();
        }
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
        if (Input.GetKey(KeyCode.Space)  && isReady == true)
        {

            adBLock();

        }
    }

    void adBLock()
    {
        if (charges >= 1)
        {
            var a = Instantiate(ball, transform.position, ball.transform.rotation);
            a.SetActive(true);
            charges += -1;
            text.SetText(charges.ToString());
            StartCoroutine(timeout());
        }
    }

    IEnumerator timeout()
    {
        isReady = false;
        yield return new WaitForSeconds(waitingtime);
        isReady = true;
    }

    void Win()
    {
        Debug.Log("Win");
        Time.timeScale = 0;
        winner.SetActive(true);
    }

    void lose()
    {
        Time.timeScale = 0;
        Debug.Log("Lose");
        gover.SetActive(true);
    }
}
