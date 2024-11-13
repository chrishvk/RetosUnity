using UnityEngine;

public class reto4 : MonoBehaviour
{
    public GameObject jugador;
    void Start()
    {
        
    }

    private void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Chocarooon");
        Destroy(collision.gameObject);
    }
}
