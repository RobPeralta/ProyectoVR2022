using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    public CharacterController personajeControl;
    public Vector3 velocidadPersonaje;
    public bool estaEnPiso;
    public float gravedad, aceleracionPersonaje, fuerzaSalto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estaEnPiso = personajeControl.isGrounded;
        if(estaEnPiso && velocidadPersonaje.y < 0)
        {
            velocidadPersonaje.y = 0;
        }

        Vector3 mueve = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(mueve != Vector3.zero)
        {
            mueve = gameObject.transform.forward;
        }
        personajeControl.Move(mueve*Time.deltaTime*aceleracionPersonaje);

        //if(mueve != Vector3.zero)
        //{
        //    gameObject.transform.forward = mueve;
        //}
        velocidadPersonaje.y += gravedad * Time.deltaTime;
        personajeControl.Move(velocidadPersonaje * Time.deltaTime);
    }
}
