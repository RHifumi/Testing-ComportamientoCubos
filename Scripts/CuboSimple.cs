using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CuboSimple : Cubo //Herencia de Cubo y MonoBehaviour
{
    //Ejemplo contrario a CuboSeguidor, aunque tengan la misma clase base, sobreescribo los 3 metodos que dan identidad y comportamiento
    //Determino un color aleatorio, escala estandar y que se desplace en linea recta.
    public override void Color()
    {
        Color color = new Color(r: UnityEngine.Random.Range(0f, 1f), g: UnityEngine.Random.Range(0f, 1f), b: UnityEngine.Random.Range(0f, 1f));
        Cuerpo.GetComponent<Renderer>().material.color = color;
    }

    public override void Tam()
    {
        rb = GetComponent<Rigidbody>();
        rb.transform.localScale = new Vector3(1,1,1);
    }

    public override void Mover()
    {
        transform.Translate(Vector3.forward * 1f * Time.deltaTime);
    }


}
