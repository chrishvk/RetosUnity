using UnityEngine;

//Toda la salida es por consola

public class reto2 : MonoBehaviour
{
    private int puntos = 0;

    void Start()
    {
        Puntaje();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Cantidad(1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Cantidad(-1);
        }
    }

    public void Cantidad(int cant)
    {
        puntos += cant;
        Puntaje();
    }

    private void Puntaje()
    {
        Debug.Log("Puntaje: " + puntos);
    }
}
