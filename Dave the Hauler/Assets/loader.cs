using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loader : MonoBehaviour
{
    public void loadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void exitApp()
    {
        Application.Quit();
    }
}
