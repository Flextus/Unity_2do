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
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector2.right * 1 * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.position = new Vector2(transform.position.x - 1, transform.position.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
        Debug.Log("ouch");   
        }
        Debug.Log("Player touched something....");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
