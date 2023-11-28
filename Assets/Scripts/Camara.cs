using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    bool presionando;
    // Start is called before the first frame update
    void Start()
    {

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

        if (presionando == true) 
        {
            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit interactuando;

            if (Physics.Raycast(rayoCamara, out interactuando))
            {
             
                transform.position = new Vector3(transform.position.x - mouseX,transform.position.y, transform.position.z - mouseY);

                Debug.Log(transform.position + "MouseX " + mouseX);
            }
        }
    }
}