using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loader : MonoBehaviour
{
    public GameObject boxObject; // Referencia al objeto de la caja

    private BoxController boxController;

    void Start()
    {
        // Obtener el componente BoxController del objeto de la caja
        if (boxObject != null)
        {
            boxController = boxObject.GetComponent<BoxController>();
        }
    }

    public void loadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void exitApp()
    {
        Application.Quit();
    }


}
