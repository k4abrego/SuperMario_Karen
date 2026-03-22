//Ana Karen Abrego Flores
//A01753979

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

// Maneja el boton de regreso para volver al menu principal.
public class Regresa : MonoBehaviour
{
    private UIDocument menu;
    private Button BotonRegresa; 

    // Obtiene el boton de UI Toolkit y suscribe su accion.
    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        
        BotonRegresa = root.Q<Button>("BotonRegresar");
        BotonRegresa.clicked += Regresar;
    }

    // Desuscribe el evento al desactivar para evitar referencias colgantes.
    void OnDisable()
    {
        BotonRegresa.clicked -= Regresar;
        //botonRegresa.UnregisterCallback<ClickEvent>(Regresar);
    }

    // Carga la escena del menu.
    void Regresar()
    {
        SceneManager.LoadScene("Menu");
    }


}
