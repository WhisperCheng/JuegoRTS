using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Cancelar : MonoBehaviour
{
    public GameObject botonMovimiento;
    public GameObject botonCancelar;
    public GameObject botonProps;
    public GameObject props;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void cancelarProps()
    {
        botonMovimiento.SetActive(true);
        botonCancelar.SetActive(false);
        botonProps.SetActive(true);
        props.SetActive(false);
    }
    public void cancelarMovimiento()
    {
        Camara.camaraActivado = false;
        botonMovimiento.SetActive(true);
        botonCancelar.SetActive(false);
        botonProps.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
