using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isBeingDragged = false;
    private Transform playerTransform;

    public float dragSpeed = 5.0f;

    public bool hasReachedMeta = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        hasReachedMeta = false;

        if (isBeingDragged && playerTransform != null)
        {
            Vector2 direction = (playerTransform.position - transform.position).normalized;
            rb.velocity = direction * dragSpeed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }



    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hasReachedMeta = true;
            Debug.Log("box true");
        }
        Debug.Log(collision.gameObject.tag);
    }


    public void sacaui()
    {
        
    }
}
