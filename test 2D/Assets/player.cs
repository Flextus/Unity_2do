using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public BoxCollider2D box;
    public Rigidbody2D rb;
    public float jump;
    public bool floortouch;
    public Animator animator;
    public float xvel;

    

    // Start is called before the first frame update
    void Start()
    {
        // box.enabled = false;
        box = this.gameObject.GetComponent<BoxCollider2D>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * xvel * Time.deltaTime);
            animator.SetBool("walkR", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * xvel * Time.deltaTime);
            animator.SetBool("walkL", true);
        }
        else
        {
            animator.SetBool("walkL", false);
            animator.SetBool("walkR", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && floortouch) 
        {
            rb.AddForce(Vector2.up * jump);
            floortouch = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

        }

        if (collision.gameObject.tag == "Floor")
        {
            floortouch = true;
        }
    }
}
