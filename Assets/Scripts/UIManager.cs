using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI vidas;
    public TextMeshProUGUI gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacion.text = GameManager.instance.puntuacion.ToString();

        tiempo.text = Time.time.ToString("00.00");

        if(GameManager.instance.vidas <= 0)
        {
            gameover.gameObject.SetActive(true);
        }
    }
}
