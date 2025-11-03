using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cubo : MonoBehaviour
{
    //Cuando una subclase hereda de una clase base, abstracta o no, hereda todas las variables y todos los metodos no privados,aunque no sean abstractos.
    //Estás varibales no necesitan volver a ser declaradas por subclases.
    public GameObject Cuerpo;
    protected Rigidbody rb;

    //Creo 3 metodos abstractos, que las subclases están obligadas a implementar, Color y Tamño al momento de generarse.
    //y un metodo Mover en el Update para poder definir la forma en que se mueven por el mundo.
    public abstract void Mover();
    public abstract void Color();
    public abstract void Tam();

    //Metodos Virutal por defecto en unity, para determinar una identidad de color, tamaño y forma de moverse.
    //Unimos el ciclo de vida de unity con herencia
    protected virtual void Start()
    {   
        Color();
        Tam();
    }

    protected virtual void Update()
    {
        Mover();
    }
}
