using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonProps : MonoBehaviour
{
    public GameObject botonMovimiento;
    public GameObject botonCancelar;
    public GameObject botonprops;
    public GameObject props;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void boton()
    {
        botonMovimiento.SetActive(false);
        botonCancelar.SetActive(true);
        botonprops.SetActive(false);
        props.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
