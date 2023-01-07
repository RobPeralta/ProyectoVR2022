using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Reaparecer : MonoBehaviour
{
    public float reapareceDebajoDeAltura = 0.1f;
    Vector3 posicionInicial;
    Quaternion rotacionInicial;

   
    void Start()
    {
        posicionInicial = transform.position;
        rotacionInicial = transform.rotation;
    }

    void Update()
    {
        if (transform.position.y <= reapareceDebajoDeAltura)
        {
            transform.position = posicionInicial;
            transform.rotation = rotacionInicial;

        }
    }
}

