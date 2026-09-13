using UnityEngine;

public class ArrastrarSprite : MonoBehaviour
{
    private Vector3 offset;
    private bool estaArrastrando = false;

    void OnMouseDown()
    {
        // Calcula la diferencia entre la posicion del objeto y el clic del raton
        offset = transform.position - ObtenerPosicionRaton();
        estaArrastrando = true;
    }

    void OnMouseDrag()
    {
        if (estaArrastrando)
        {
            // Actualiza la posicion del Sprite mientras se mantiene presionado
            transform.position = ObtenerPosicionRaton() + offset;
        }
    }

    void OnMouseUp()
    {
        estaArrastrando = false;
    }

    private Vector3 ObtenerPosicionRaton()
    {
        Vector3 posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionRaton.z = 0f; // Asegura que se mantenga en el plano 2D
        return posicionRaton;
    }
}