using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    public GameObject uileveluno;
    public GameObject boxObject; // Referencia al objeto de la caja
    private BoxController boxController;

    void Start()
    {
        uileveluno.SetActive(false);
        boxController = boxObject.GetComponent<BoxController>();
    }

    public void magic()
    {
        // Verificar si la caja ha alcanzado la meta
        if (uileveluno.activeInHierarchy == false && boxController.hasReachedMeta)
        {
            uileveluno.SetActive(true);
        }
        else
        {
            uileveluno.SetActive(false);
        }
    }
}
