using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Variables para controlar el movimiento
    public float speed = 5.0f;
    private Animator walker;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Obtener el componente Animator
        walker = GetComponent<Animator>();
        // Obtener el componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Resetear los booleans de animación
        walker.SetBool("walkingRight", false);
        walker.SetBool("walkingLeft", false);
        walker.SetBool("walkingUp", false);
        walker.SetBool("walkingDown", false);

        // Vector de movimiento
        Vector2 movement = Vector2.zero;

        // Movimiento en X positiva (derecha)
        if (Input.GetKey(KeyCode.D))
        {
            movement.x = speed;
            walker.SetBool("walkingRight", true);
        }

        // Movimiento en X negativa (izquierda)
        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -speed;
            walker.SetBool("walkingLeft", true);
        }

        // Movimiento en Y positiva (arriba)
        if (Input.GetKey(KeyCode.W))
        {
            movement.y = speed;
            walker.SetBool("walkingUp", true);
        }

        // Movimiento en Y negativa (abajo)
        if (Input.GetKey(KeyCode.S))
        {
            movement.y = -speed;
            walker.SetBool("walkingDown", true);
        }

        // Actualizar la velocidad del Rigidbody2D
        rb.velocity = movement;

        // Actualizar los parámetros del Animator
        walker.SetBool("walkingRight", movement.x > 0);
        walker.SetBool("walkingLeft", movement.x < 0);
        walker.SetBool("walkingUp", movement.y > 0);
        walker.SetBool("walkingDown", movement.y < 0);
    }
}
