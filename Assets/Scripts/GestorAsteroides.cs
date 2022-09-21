using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorAsteroides : MonoBehaviour
{
    public GameObject asteroide_base;
    public int asteroides_min = 2;
    public int asteroides_max = 8;
    public float spawn_max_x = 10;
    public float spawn_max_y = 6;
    // Start is called before the first frame update
    void Start()
    {
        int total = Random.Range(asteroides_min, asteroides_max);
        for (int i = 0; i < total; i++)
        {
            Debug.Log("Instanciado asteroide numero: " + i);
            Vector3 posicion = new Vector3(Random.Range(-spawn_max_x, spawn_max_x), Random.Range(-spawn_max_y, spawn_max_y));
            Instantiate(asteroide_base, posicion, Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 365))));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
