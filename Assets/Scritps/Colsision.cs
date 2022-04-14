using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colsision : MonoBehaviour
{
    public Score puntos;
    //Objetos 3D
    void OnCollisionEnter(Collision col)
    {

    }
    //Objetos 2D
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "plataforma")
        {
            Debug.Log("Me estas pegando");
            puntos.sumascore(2);
        }
    }
}
