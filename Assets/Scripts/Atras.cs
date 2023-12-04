using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atras : MonoBehaviour
{
    public GameObject props;
    public GameObject atras;
    public GameObject botonCancelar;
    // Start is called before the first frame update
    void Start()
    {
        //Crear.propArbusto
    }

    public void back()
    {
        atras.SetActive(false);
        props.SetActive(true);
        botonCancelar.SetActive(true);
        //propArbusto = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
