using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCamara : MonoBehaviour
{
    public Camara camara;
    public GameObject botonMovimiento;
    public GameObject botonCancelar;
    public GameObject botonProps;
    public GameObject botonBorrar;
    public GameObject botonBorrarTodo;
    // Start is called before the first frame update
    public void funcionBoton()
    {
        camara.activarModoCamara();
        botonMovimiento.SetActive(false);
        botonCancelar.SetActive(true);
        botonProps.SetActive(false);
        botonBorrar.SetActive(false);
        botonBorrarTodo.SetActive(false);
    }
 
}
