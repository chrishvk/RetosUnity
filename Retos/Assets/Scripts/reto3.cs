using UnityEngine;

//Toda la salida es por consola

public class reto3 : MonoBehaviour
{
    private int puntos = 3;

    private void Start()
    {
        InvokeRepeating("ReducirPuntos", 1f, 1f);
    }

    private void ReducirPuntos()
    {
        puntos--;

        if (puntos > 0)
        {
            Debug.Log("Puntaje: " + puntos);
        }
        else
        {
            Debug.Log("Tu personaje ha muerto");
            Destroy(gameObject);
            CancelInvoke("ReducirPuntos");
        }
    }
}

