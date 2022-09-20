using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vel_min;
    public float vel_max;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 direccion = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        Debug.Log(direccion);
        float velocidad = Random.Range(vel_min, vel_max);
        rb.AddForce(direccion * velocidad);
    }
}
