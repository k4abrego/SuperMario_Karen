using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    private UIDocument menu;
    private Button BotonJugar;
    private Button BotonAyuda;
    private Button BotonCreditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        
        BotonJugar = root.Q<Button>("BotonJugar");
        BotonAyuda = root.Q<Button>("BotonAyuda");
        BotonCreditos = root.Q<Button>("BotonCreditos");

        //Callbacks
        BotonJugar.RegisterCallback<ClickEvent>(AbrirJugar);
        //BotonJugar.RegisterCallback<ClickEvent>((ClickEvent) => SceneManager.LoadScene(0)); //cuando alguien le de click al botón haz esto
        if (BotonAyuda != null) //código de seguridad para evitar errores en caso de que el botón no exista en la escena
        {
            BotonAyuda.RegisterCallback<ClickEvent>(AbrirAyuda);
        }
    }

    private void AbrirJugar(ClickEvent evt)
    {
        SceneManager.LoadScene("SampleScene");
    }


    // void OnDisable()
    // {
    //     botonJugarMapa.UnregisterCallback<ClickEvent>(AbrirJugarMapa);
    // }
    //no combiene usarlas porque no será necesorio unregister el callback.
    private void AbrirAyuda(ClickEvent evt)
    {
        SceneManager.LoadScene("/");
    }

}
