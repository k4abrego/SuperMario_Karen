//Ana Karen Abrego Flores
//A01753979

using UnityEngine;

// Detecta si el personaje esta tocando el suelo para permitir saltar solo cuando esta en el piso
public class EstadoPersonaje : MonoBehaviour
{
    // Solo esta clase modifica el estado; otras clases solo lo consultan
    public bool estaEnPiso {get; private set;} = false;

    // Marca al personaje en el suelo cuando entra al trigger
    void OnTriggerEnter2D(Collider2D collision)
    {
        estaEnPiso = true;
    }

    // Marca al personaje fuera del suelo cuando sale del trigger
    void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;
        print(estaEnPiso);
    }
}