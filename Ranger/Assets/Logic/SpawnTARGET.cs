using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTARGET : MonoBehaviour
{
    public GameObject prefabtarget;
    public float intervalo = 5f;

    private Coroutine spawnCoroutine;

    void Start()
    {
        TargetScript contador = new TargetScript();
        spawnCoroutine = StartCoroutine(TargetSpawn());
        StartCoroutine(stopmuertes(contador.muertes));
    }

    private IEnumerator TargetSpawn()
    {
        while (true)
        {
            Instantiate(prefabtarget, transform.position, transform.rotation);
            yield return new WaitForSeconds(intervalo);
        }
    }

    private IEnumerator stopmuertes(int muertes)
    {
        if (muertes >= 10)
        {
            StopCoroutine(spawnCoroutine);
            Debug.Log("Corrutina de generación detenida.");
        }
        yield return null;
    }
}
