using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Reaparecer : MonoBehaviour
{
    public float reapareceDebajoDeAltura = 0.1f;
    public List<GameObject> objetivosQueReinician = new List<GameObject>();
    Vector3 posicionInicial;
    Quaternion rotacionInicial;

    private IEnumerator OnCollisionEnter(Collision collision)
    {
        for (int t = 0; t < objetivosQueReinician.Count; t++)
        {
            if (collision.collider.name == objetivosQueReinician[t].name)
            {
                yield return new WaitForSeconds(1);
                transform.position = posicionInicial;
                transform.rotation = rotacionInicial;
            }
        }
    }
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

