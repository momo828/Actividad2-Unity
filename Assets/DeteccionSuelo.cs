using UnityEngine;

public class DeteccionSuelo : MonoBehaviour
{
    private Animator animador; // Variable para controlar tu Mecanim

    private void Start()
    {
        // Al iniciar, Unity busca tu Animator y lo guarda para usarlo
        animador = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Revisamos si con lo que chocamos tiene la etiqueta "Suelo"
        if (collision.gameObject.CompareTag("Suelo"))
        {
            // Encendemos el interruptor de tu Animator
            animador.SetBool("enElSuelo", true); 
            Debug.Log("¡Chocamos! Cambiando a estado de Reposo.");
        }
    }
}