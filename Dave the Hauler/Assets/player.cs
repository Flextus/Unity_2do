using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Variables para controlar el movimiento
    public float speed = 5.0f;
    private Animator animator;
    private Rigidbody2D rb;

    // Booleans para activar animaciones
    private bool isWalkingRight = false;
    private bool isWalkingLeft = false;
    private bool isWalkingUp = false;
    private bool isWalkingDown = false;

    // Start is called before the first frame update
    void Start()
    {
        // Obtener el componente Animator
        animator = GetComponent<Animator>();
        // Obtener el componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Resetear los booleans de animación
        isWalkingRight = false;
        isWalkingLeft = false;
        isWalkingUp = false;
        isWalkingDown = false;

        // Vector de movimiento
        Vector2 movement = Vector2.zero;

        // Movimiento en X positiva (derecha)
        if (Input.GetKey(KeyCode.D))
        {
            movement.x = speed;
            isWalkingRight = true;
        }

        // Movimiento en X negativa (izquierda)
        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -speed;
            isWalkingLeft = true;
        }

        // Movimiento en Y positiva (arriba)
        if (Input.GetKey(KeyCode.W))
        {
            movement.y = speed;
            isWalkingUp = true;
        }

        // Movimiento en Y negativa (abajo)
        if (Input.GetKey(KeyCode.S))
        {
            movement.y = -speed;
            isWalkingDown = true;
        }

        // Actualizar la velocidad del Rigidbody2D
        rb.velocity = movement;

        // Actualizar los parámetros del Animator
        animator.SetBool("isWalkingRight", isWalkingRight);
        animator.SetBool("isWalkingLeft", isWalkingLeft);
        animator.SetBool("isWalkingUp", isWalkingUp);
        animator.SetBool("isWalkingDown", isWalkingDown);
    }
}
