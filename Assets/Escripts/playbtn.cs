using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbtn : MonoBehaviour
{
public void play()
    {
        SceneManager.LoadScene("SampleText");
    }
}
