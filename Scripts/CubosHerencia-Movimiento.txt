using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiniMove : MonoBehaviour
{
    private float velocidad = 10.0f;

    void Update()
    {

        float movimientoAdelante = Input.GetAxis("Vertical") * velocidad;
        float movimientoLados = Input.GetAxis("Horizontal") * velocidad;

        //Suavizar los movimientos
        movimientoAdelante *= Time.deltaTime;
        movimientoLados *= Time.deltaTime;

        //Siempre nos referimos al transform del objeto madre
        transform.Translate(movimientoLados, 0, movimientoAdelante);
    }
}
