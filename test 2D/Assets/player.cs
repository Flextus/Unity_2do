using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public BoxCollider2D box;
    public Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        // box.enabled = false;
        box = this.gameObject.GetComponent<BoxCollider2D>();




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
