using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipemove : MonoBehaviour
{
    public float movespeed = 15;
    public float deathpipe = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        // Time.detatime se usa para relacionar la accion con el tiempo real, en vez de la tasa de fps de cada usuario

        if (transform.position.x < deathpipe) 
        {
            Debug.Log("Pipe Deleted");  //manda un mensaje a la consola
            Destroy(gameObject);
        }
    }
}
