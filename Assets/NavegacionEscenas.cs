using UnityEngine;
using UnityEngine.SceneManagement;

public class NavegacionEscenas : MonoBehaviour
{
    // Carga la escena segun su nombre
    public void IrAEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    // Carga la escena segun su indice en el Build Settings
    public void IrAEscenaPorIndice(int indiceEscena)
    {
        SceneManager.LoadScene(indiceEscena);
    }
}