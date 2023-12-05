using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
    public Camara camara;
    public GameObject botonArbusto;
    public GameObject botonGranero;
    public GameObject botonSilo;
    public GameObject botonArbol;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void botonArbustoClick()
    {
        camara.bush();
        camara.desactivarBarn();
        camara.desactivarSilo();
        camara.desactivarTree();
    }
    public void botonTreeClick()
    {
        camara.tree();
        camara.desactivarSilo();
        camara.desactivarBush();
        camara.desactivarBarn();
    }
    public void botonBarnClick()
    {
        camara.barn();
        camara.desactivarTree();
        camara.desactivarBush();
        camara.desactivarSilo();
    }
    public void botonSiloClick()
    {
        camara.Silo();
        camara.desactivarBush();
        camara.desactivarBarn();
        camara.desactivarTree();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
