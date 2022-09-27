using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideController : MonoBehaviour
{
    public GestorAsteroides gestor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Muerte()
    {

    }

    //void OnDestroy()
    //{
    //    GameObject asteroide1 = Instantiate(gestor.asteroide_base, transform.position, transform.rotation);
    //    asteroide1.GetComponent<AsteroideController>().gestor = gestor;
    //    GameObject asteroide2 = Instantiate(gestor.asteroide_base, transform.position, transform.rotation);
    //    asteroide2.GetComponent<AsteroideController>().gestor = gestor;
    //}
}
