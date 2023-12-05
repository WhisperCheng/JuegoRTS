using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// Unicamente se encarga del personaje (camara) -> muevo, añado cosas. LANZO RAYOS
public class Camara : MonoBehaviour
{
    public bool propArbusto;
    public bool propArbol;
    public bool propGranero;
    public bool propSilo;
    bool presionando;
    public bool camaraActivado;
    public GameObject arbusto;
    public GameObject arbol;
    public GameObject granero;
    public GameObject silo;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void bush()
    {
        propArbusto = true;
    }
    public void desactivarBush()
    {
        propArbusto = false;
    }
    public void tree()
    {
        propArbol = true;
    }
    public void desactivarTree()
    {
        propArbol = false;
    }
    public void barn()
    {
        propGranero = true;
    }
    public void desactivarBarn()
    {
        propGranero = false;
    }
    public void Silo()
    {
        propSilo = true;
    }
    public void desactivarSilo()
    {
        propSilo = false;
    }
    public void activarModoCamara()
    {
        camaraActivado = true;
    }

    public void desactivarModoCamara()
    {
        camaraActivado = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (camaraActivado)
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

            if (presionando == true)
            {
                Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);

                RaycastHit interactuando;

                if (Physics.Raycast(rayoCamara, out interactuando))
                {
                    transform.position = new Vector3(transform.position.x - mouseX, transform.position.y, transform.position.z - mouseY);
                }
            }
        }
        if (propArbusto == true && Input.GetMouseButtonDown(0))
        {
            
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rayoArbusto;

            if (Physics.Raycast(laser, out rayoArbusto))
            {
                if(rayoArbusto.collider.gameObject.layer == LayerMask.NameToLayer("Suelo"))
                {
                    GameObject.Instantiate(arbusto, rayoArbusto.point, Quaternion.Euler(-90, 0, 0));
                }
            }
        }
        if (propGranero == true && Input.GetMouseButtonDown(0))
        {

            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rayoBarn;

            if (Physics.Raycast(laser, out rayoBarn))
            { 
                if(rayoBarn.collider.gameObject.layer == LayerMask.NameToLayer("Suelo"))
                {
                    GameObject.Instantiate(granero, rayoBarn.point, Quaternion.identity);
                }
            }
        }
        if (propArbol == true  && Input.GetMouseButtonDown(0))
        {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rayoTree;

            if (Physics.Raycast(laser, out rayoTree))
            {
                if (rayoTree.collider.gameObject.layer == LayerMask.NameToLayer("Suelo"))
                {
                    GameObject.Instantiate(arbol, rayoTree.point, Quaternion.Euler(-90,0,0));
                }
            }
        }
    }
}
