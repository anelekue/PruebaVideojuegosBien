using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float movimientoCap = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        transform.Translate(movimientoCap, 0, 0);
    }
}