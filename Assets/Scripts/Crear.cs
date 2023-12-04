using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
    static public bool propArbusto;
    static public bool propArbol;
    static public bool propGranero;
    static public bool propSilo;
    public GameObject botonAtras;
    public GameObject botonArbusto;
    public GameObject botonGranero;
    public GameObject botonSilo;
    public GameObject botonArbol;
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
    public void tree()
    {
        propArbol = true;
    }
    public void barn()
    {
        propGranero = true;
    }
    public void Silo()
    {
        propSilo = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (propArbusto == true && Input.GetMouseButtonDown(0))
        {
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit rayoArbusto;

            Debug.Log("RayoArbusto");

            if (Physics.Raycast(laser, out rayoArbusto))
            {
                GameObject.Instantiate(arbusto, rayoArbusto.point, Quaternion.identity);
            }
        }
    }
}
