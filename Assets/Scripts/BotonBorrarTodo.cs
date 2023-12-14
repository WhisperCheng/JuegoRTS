using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonBorrarTodo : MonoBehaviour
{
    public GameObject botonMovimiento;
    public GameObject botonCancelar;
    public GameObject botonCanvasBorrar;
    public GameObject botonBorrar;
    public GameObject botonBorrarTodo;
    public GameObject botonProps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FuncionBotonBorrarTodo()
    {
        botonMovimiento.SetActive(false);
        botonCancelar.SetActive(true);
        botonCanvasBorrar.SetActive(true);
        botonBorrar.SetActive(false);
        botonBorrarTodo.SetActive(false);
        botonProps.SetActive(false);
    }
}
