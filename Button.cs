using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {
    public void De1()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Re1()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void Re2()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void Back()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void Star1()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Star2()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void Exie()
    {
        Application.Quit();
    }
}
