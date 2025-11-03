using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEscapador : CuboSeguidor //herencia de CuboSeguidor, Cubo y MonoBehaviour
{
    //Vuelvo a sobreescribir el Color.
    public override void Color()
    {
        Color color = new Color(0, 0, 1);
        Cuerpo.GetComponent<Renderer>().material.color = color;
    }

    //Utlizo Base.Start para utilizar la implementacion del Override anterior, pero ajusto una velocidad negativa para dar el efecto de alejarse del objetivo
    protected override void Start()
    {
        rapidez = -3;
        base.Start();
    } 
}
