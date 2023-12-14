using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BorrarTodo : MonoBehaviour
{
    public GameObject[] listaArbol;
    public GameObject[] listaArbusto;
    public GameObject[] listaGranero;
    public GameObject[] listaCasita;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        listaArbol = GameObject.FindGameObjectsWithTag("Arbol");
        listaArbusto = GameObject.FindGameObjectsWithTag("Arbusto");
        listaGranero = GameObject.FindGameObjectsWithTag("Granero");
        listaCasita = GameObject.FindGameObjectsWithTag("Casita");
    }
    public void BorrarArbol()
    {
        foreach(GameObject arbol in listaArbol)
        {
            Destroy(arbol);
        }
    }
    public void BorrarArbusto()
    {
        foreach(GameObject arbusto in listaArbusto)
        {
            Destroy(arbusto);
        }
    }
    public void BorrarGranero()
    {
        foreach(GameObject granero in listaGranero)
        {
            Destroy(granero);
        }
    }
    public void BorrarCasita()
    {
        foreach (GameObject casita in listaCasita)
        {
            Destroy(casita);
        }
    }
}
