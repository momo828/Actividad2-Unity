using UnityEngine;
using UnityEngine.SceneManagement; //  cambiar de escenas

public class Navegacion : MonoBehaviour
{
    // nos permitira escribir el nombre de la pagina a la que queremos ir
    public void IrA_Pagina(string nombreDeLaEscena)
    {
        SceneManager.LoadScene(nombreDeLaEscena);
    }
}