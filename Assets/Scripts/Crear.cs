using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
    public Camara camara;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void botonArbustoClick()
    {
        camara.bush();
        camara.desactivarBarn();
        camara.desactivarcasita();
        camara.desactivarTree();
    }
    public void botonTreeClick()
    {
        camara.tree();
        camara.desactivarcasita();
        camara.desactivarBush();
        camara.desactivarBarn();
    }
    public void botonBarnClick()
    {
        camara.barn();
        camara.desactivarTree();
        camara.desactivarBush();
        camara.desactivarcasita();
    }
    public void botonCasitaClick()
    {
        camara.casita();
        camara.desactivarBush();
        camara.desactivarBarn();
        camara.desactivarTree();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
