using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Camara : MonoBehaviour
{
    bool presionando;
    static bool camaraActivado;
    public GameObject botonMovimiento;
    public GameObject botonCancelar;
    public GameObject botonProps;
    public GameObject props;
    // Start is called before the first frame update
    void Start()
    {
        botonCancelar = GameObject.Find("ButtonCancelar");
        botonMovimiento = GameObject.Find("Button");
        botonProps = GameObject.Find("ButtonProps");
        props = GameObject.Find("CanvasProps");
    }

    public void funcionBoton()
    {
        camaraActivado = true;
        botonMovimiento.SetActive(false);
        botonCancelar.SetActive(true);
        botonProps.SetActive(false);
    }
    public void funcionBotonCancelar()
    {
        camaraActivado = false;
        botonCancelar.SetActive(false);
        botonMovimiento.SetActive(true);
        botonProps.SetActive(true);
        props.SetActive(false);
    }

    public void componentes()
    {
        botonCancelar.SetActive(true);
        botonMovimiento.SetActive(false);
        botonProps.SetActive(false);
        props.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (Input.GetMouseButtonDown(0))
        {
            presionando = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            presionando = false;
        }

        if (presionando == true && camaraActivado == true) 
        {
            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit interactuando;

            if (Physics.Raycast(rayoCamara, out interactuando))
            {
                transform.position = new Vector3(transform.position.x - mouseX,transform.position.y, transform.position.z - mouseY);
            }
        }
    }
}
