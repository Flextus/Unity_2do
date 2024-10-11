using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Variables para controlar el movimiento
    public float speed = 5.0f;
    private Animator animator;

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
    }

    // Update is called once per frame
    void Update()
    {
        // Resetear los booleans de animación
        isWalkingRight = false;
        isWalkingLeft = false;
        isWalkingUp = false;
        isWalkingDown = false;

        // Movimiento en X positiva (derecha)
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            isWalkingRight = true;
        }

        // Movimiento en X negativa (izquierda)
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            isWalkingLeft = true;
        }

        // Movimiento en Y positiva (arriba)
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            isWalkingUp = true;
        }

        // Movimiento en Y negativa (abajo)
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            isWalkingDown = true;
        }

        // Actualizar los parámetros del Animator
        animator.SetBool("isWalkingRight", isWalkingRight);
        animator.SetBool("isWalkingLeft", isWalkingLeft);
        animator.SetBool("isWalkingUp", isWalkingUp);
        animator.SetBool("isWalkingDown", isWalkingDown);
    }
}
