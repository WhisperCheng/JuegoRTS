using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Cancelar : MonoBehaviour
{
    public Camara camara;
    public GameObject botonMovimiento;
    public GameObject botonCancelar;
    public GameObject botonProps;
    public GameObject props;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void cancelarMovimiento()
    {
        camara.desactivarBarn();
        camara.desactivarBush();
        camara.desactivarModoCamara();
        botonMovimiento.SetActive(true);
        botonCancelar.SetActive(false);
        botonProps.SetActive(true);
        props.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
