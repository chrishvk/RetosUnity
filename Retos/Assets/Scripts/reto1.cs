using UnityEngine;

//Toda la salida es por consola

public class reto1 : MonoBehaviour
{
    private int puntaje = 0;

    private void Start()
    {
        InvokeRepeating("AumentarScore", 1f, 1f);
    }

    private void AumentarScore()
    {
        puntaje += 1;
        Debug.Log("Puntaje: " + puntaje);
    }
}
