//Ana Karen Abrego Flores
//A01753979

using UnityEngine;

// Actualiza la animacion del personaje segun su movimiento y estado en el suelo
public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr; 
    private EstadoPersonaje estado;

    // Cachea los componentes necesarios al iniciar el juego
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    // Sincroniza parametros del Animator en cada frame
    void Update()
    {
        animator.SetFloat("velocidad", Mathf.Abs(rb.linearVelocity.x));
        sr.flipX = rb.linearVelocity.x < -0.1;
        animator.SetBool("enPiso", estado.estaEnPiso);
    }
}