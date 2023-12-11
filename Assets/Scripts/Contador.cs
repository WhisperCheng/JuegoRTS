using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public GameObject[] arbol;
    public GameObject[] arbusto;
    public GameObject[] granero;
    public GameObject[] casita;
    public TMP_Text recuento;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        arbol = GameObject.FindGameObjectsWithTag("Arbol");
        arbusto = GameObject.FindGameObjectsWithTag("Arbusto");
        granero = GameObject.FindGameObjectsWithTag("Granero");
        casita = GameObject.FindGameObjectsWithTag("Casita");

        recuento.text = "Arboles = " + arbol.Length.ToString() + "\n";
        recuento.text = recuento.text + "Arbustos = " + arbusto.Length.ToString() + "\n";
        recuento.text = recuento.text + "Graneros = " + granero.Length.ToString() + "\n";
        recuento.text = recuento.text + "Casitas = " + casita.Length.ToString() + "\n";
    }
}
