using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class IA : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        // Funciones muy costosas
        agent = GetComponent <NavMeshAgent>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Player.transform.position);
    }
}
