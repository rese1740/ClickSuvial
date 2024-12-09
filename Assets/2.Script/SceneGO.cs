using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGO : MonoBehaviour
{
    public void GoMiain()
    {
        SceneManager.LoadScene("Main");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GoStart()
    {
        SceneManager.LoadScene("Start");

    }
}
