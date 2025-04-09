using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject balaPrefab;     // Prefab de la bala
    public Transform puntoDisparo;    // Lugar desde donde se dispara
    public float fuerzaDisparo = 20f; // Velocidad de la bala

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Cambia la tecla si quieres
        {
            Disparar();
        }
    }

    void Disparar()
    {
        GameObject bala = Instantiate(balaPrefab, puntoDisparo.position, puntoDisparo.rotation);
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.velocity = puntoDisparo.forward * fuerzaDisparo;
    }
}