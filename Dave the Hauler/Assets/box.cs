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
    private bool _hasReachedMeta = false; // Variable privada para el booleano

    // Propiedad pública para hasReachedMeta con lógica de cambio
    public bool hasReachedMeta
    {
        get { return _hasReachedMeta; }
        set
        {
            if (_hasReachedMeta != value)
            {
                _hasReachedMeta = value;
                Debug.Log("hasReachedMeta: " + _hasReachedMeta);
            }
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isBeingDragged = true;
            playerTransform = collision.transform;
        }

        if (collision.gameObject.CompareTag("meta"))
        {
            hasReachedMeta = true;

        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isBeingDragged = false;
            playerTransform = null;
        }
    }

    public void sacaui()
    {

    }
}
