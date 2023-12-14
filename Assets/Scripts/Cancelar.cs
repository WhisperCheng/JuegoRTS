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
    public GameObject botonBorrar;
    public GameObject botonBorrarTodo;
    public GameObject botonCanvasBorrar;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void cancelarMovimiento()
    {
        camara.desactivarBarn();
        camara.desactivarBush();
        camara.desactivarcasita();
        camara.desactivarTree();
        camara.desactivarModoCamara();
        camara.desactivarBorrar();
        botonMovimiento.SetActive(true);
        botonCancelar.SetActive(false);
        botonProps.SetActive(true);
        props.SetActive (false);
        botonBorrar.SetActive(true);
        botonBorrarTodo.SetActive(true);
        botonCanvasBorrar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
