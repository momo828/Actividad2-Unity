using UnityEngine;

public class DeteccionSuelo : MonoBehaviour
{
    // Esta variable guarda el estado de nuestro personaje
    public bool estaEnElSuelo = false;

    // Esta función de Unity se dispara automáticamente cuando dos Colliders chocan
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Comparamos si el objeto contra el que chocamos tiene la etiqueta "Suelo"
        if (collision.gameObject.CompareTag("Suelo"))
        {
            // Cambiamos el estado del objeto
            estaEnElSuelo = true;
            
            // Enviamos un mensaje a la consola para demostrar que funciona
            Debug.Log("¡Colisión detectada! El personaje ahora está en el suelo.");
        }
    }
}