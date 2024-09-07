using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public logicscript logic;
    public Rigidbody2D myRigidbody;
    public float flapstr;
    public bool alivebird = true;

    // Start is called before the first frame update
    void Start()
    {
        alivebird = true;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alivebird)  // cuando se usa space
        {
            myRigidbody.velocity = Vector2.up * flapstr;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        alivebird = false;
    }
}
