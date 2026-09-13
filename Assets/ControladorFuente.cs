using UnityEngine;
using TMPro; // Libreria necesaria para TextMeshPro

public class ControladorFuente : MonoBehaviour
{
    public TextMeshProUGUI textoUI; // El elemento de texto en el Canvas
    public TMP_FontAsset nuevaFuente; // La fuente a la que deseas cambiar

    // Funcion que se asignara al boton
    public void CambiarTipografia()
    {
        if (textoUI != null && nuevaFuente != null)
        {
            textoUI.font = nuevaFuente;
        }
        else
        {
            Debug.LogWarning("Falta asignar el texto o la fuente en el Inspector.");
        }
    }
}