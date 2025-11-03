using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboSeguidor : Cubo //Herencia de Cubo y MonoBehaviour
{
    //Pido por editor el objeto a seguir y una velocidad de desplazamiento.
    public GameObject objetivo;
    protected int rapidez = 1;

    //Sobresecribo con Override, Color, Tam y Mover, que se inician en los Virutal Start y Update ya definidos por la clase abstracta.
    public override void Color()
    {
        //Defino un color RGB y se lo asigno en su propiedad.
        Color color = new Color(1,0,0);
        Cuerpo.GetComponent<Renderer>().material.color = color;
    }

    public override void Tam()
    {
        //Defino proporciones de escala
        rb = GetComponent<Rigidbody>();
        rb.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
    }

    public override void Mover()
    {
        //Pido que las coordenadas,"miren" al objeto elegido, y se desplacen a la velocidad determinada hacía el
        transform.LookAt(objetivo.transform);
        transform.Translate(rapidez * Vector3.forward * Time.deltaTime);
    }

}
