using UnityEngine;

public class ControladorEnlaces : MonoBehaviour
{
    // Métodos para abrir URLs desde los botones 
    public void AbrirEnlace1()
    {
        Application.OpenURL("https://github.com"); 
    }

    public void AbrirEnlace2()
    {
        Application.OpenURL("https://unity.com");
    }

    public void AbrirEnlace3()
    {
        Application.OpenURL("https://udg.mx");
    }
}