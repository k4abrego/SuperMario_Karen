//Ana Karen Abrego Flores
//A01753979

using UnityEngine;
using UnityEngine.UIElements;

// Controla la ventana emergente de ayuda en la interfaz UI Toolkit
public class Ayuda : MonoBehaviour
{
    private UIDocument menu;

    private Button botonAyuda;
    private Button botonCloseHelp;

    private VisualElement buttonContainer;
    private VisualElement helpPopup;

    // Obtiene referencias de la UI y registra los eventos de los botones
    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonAyuda = root.Q<Button>("BtnAyuda");
        botonCloseHelp = root.Q<Button>("BtnCloseHelp");

        buttonContainer = root.Q<VisualElement>("ButtonContainer");
        helpPopup = root.Q<VisualElement>("Help");

        // Eventos
        botonAyuda.RegisterCallback<ClickEvent>(MostrarAyuda);
        botonCloseHelp.RegisterCallback<ClickEvent>(CerrarAyuda);

        // Ocultar al inicio las ventanas y se abran hasta que se seleccionen con el mouse
        helpPopup.AddToClassList("hidden");
    }

    // Muestra la ayuda y oculta los botones principales
    private void MostrarAyuda(ClickEvent evt)
    {
        buttonContainer.style.display = DisplayStyle.None;
        helpPopup.RemoveFromClassList("hidden");
    }

    // Oculta la ayuda y vuelve a mostrar los botones
    private void CerrarAyuda(ClickEvent evt)
    {
        helpPopup.AddToClassList("hidden");
        buttonContainer.style.display = DisplayStyle.Flex;
    }
}
