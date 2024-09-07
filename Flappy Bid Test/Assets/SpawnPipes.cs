using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightoffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) 
        {
            timer = timer + Time.deltaTime;
        }else
        {
            Spawn();
            timer = 0;
        }
    }
    void Spawn()
    {
        float lowpoint = transform.position.y - heightoffset;
        float highpoint = transform.position.y+ heightoffset;

        Debug.Log("Pipe Spawned");
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(highpoint, lowpoint), 0), transform.rotation);
        // new para agregar nuestro propio vaor vectoria
    }
}
