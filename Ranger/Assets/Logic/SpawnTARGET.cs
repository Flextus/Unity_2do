using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTARGET : MonoBehaviour
{
    public GameObject prefabtarget;
    public float speed = 5f;
    public float intervalo = 5f;
    public float angulo = 90f;
    public Rigidbody rb;

    private Coroutine spawnCoroutine;

    void Start()
    {
        TargetScript contador = new TargetScript();
        spawnCoroutine = StartCoroutine(TargetSpawn());
        StartCoroutine(stopmuertes(contador.muertes));
    }

    private void Update()
    {
        if (rb != null) 
        {
            rb.velocity = Vector3.forward * speed;
        }
    }

    private IEnumerator TargetSpawn()
    {
        while (true)
        {   
            GameObject diana = Instantiate(prefabtarget, transform.position, Quaternion.Euler(new Vector3(0, 0, 90)));
            rb = diana.GetComponent<Rigidbody>();

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
