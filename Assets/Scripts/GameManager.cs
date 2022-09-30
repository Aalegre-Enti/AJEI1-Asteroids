using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int vidas = 3;
    public int puntuacion = 0;

    void Awake()
    {
        instance = this;
    }

}
