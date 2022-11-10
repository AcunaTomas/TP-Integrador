using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbtn : MonoBehaviour
{
    public void play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleText");
    }

    public void retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Continue()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TextSample");
    }

}
