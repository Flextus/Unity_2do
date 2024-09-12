using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_panel : MonoBehaviour
{
    public GameObject panel; // Referencia al panel que deseas ocultar
    public float delay = 10f; // Tiempo en segundos antes de ocultar el panel

    private void Start()
    {
        // Inicia la corutina que ocultará el panel después del tiempo especificado
        StartCoroutine(HideAfterDelay());
    }

    private IEnumerator HideAfterDelay()
    {
        // Espera durante el tiempo especificado antes de ocultar el panel
        yield return new WaitForSeconds(delay);

        // Desactiva el panel para ocultarlo
        panel.SetActive(false);
        Debug.Log("Hidden Panel Successfully");
    }
}
