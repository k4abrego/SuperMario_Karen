//Ana Karen Abrego Flores
//A01753979

using UnityEngine;
using UnityEngine.InputSystem;

// Controla movimiento horizontal y salto usando el Input System.
public class MoverConInputAction : MonoBehaviour
{
    [SerializeField]

    private InputAction accionMover;

    [SerializeField]
    private InputAction accionSaltar;


    private Rigidbody2D rb;
    private EstadoPersonaje estado;

    private float velocidadX = 7f;
    private float velocidadY = 7f;
        
    // Activa acciones y cachea componentes necesarios.
    void Start()
    {
        accionMover.Enable();
        rb = GetComponent<Rigidbody2D>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    // Registra el evento de salto al habilitar el objeto.
    void OnEnable()
    {
        accionSaltar.Enable();
        accionSaltar.performed += saltar;
    }

    // Desactiva y desuscribe el salto para evitar eventos duplicados.
    void OnDisable()
    {
        accionSaltar.Disable();
        accionSaltar.performed -= saltar;
    }

    // Aplica velocidad vertical solo si el personaje esta en el suelo.
    public void saltar(InputAction.CallbackContext context)
    {
        if (estado.estaEnPiso)
        {
            rb.linearVelocityY = velocidadY;
        }
    }

    // Lee el input y actualiza la velocidad horizontal cada frame.
    void Update()
    {
        Vector2 movimiento = accionMover.ReadValue<Vector2>();
        rb.linearVelocityX = movimiento.x * velocidadX;
        
    }
}