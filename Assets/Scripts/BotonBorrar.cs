using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonBorrar : MonoBehaviour
{
    public GameObject botonMovimiento;
    public GameObject botonCancelar;
    public GameObject botonProps;
    public GameObject botonBorrar;
    public GameObject botonBorrarTodo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void botonBorrarActivar()
    {
        botonMovimiento.SetActive(false);
        botonCancelar.SetActive(true);
        botonProps.SetActive(false);
        botonBorrar.SetActive(false);
        botonBorrarTodo.SetActive(false);
    }
}
