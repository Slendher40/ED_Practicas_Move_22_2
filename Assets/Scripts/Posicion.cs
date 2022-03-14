using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour
{
    public float velocidad;
    public float gravedad;
    void Start()
    {
        //posicionamiento
        //transform.position = new Vector2(2.4f, 3);
    }

    void Update()
    {
        movimiento();
        //Intentando simular algun tipo de gravedad
        /*if (transform.position.y > -5)
        {
            transform.position = transform.position + new Vector3(0, -gravedad * Time.deltaTime);
        }*/

/* TAREA
 * Investigar como se declara un valor random en C# o Unity:
 * Random.Range
 * Una vez investigado, cambia el valor de y por ese valor random
 * Entregar un screen record del ejercicio resuelto y el script de unity
 */
        //"Teletransportacion" de un lado de la pantalla al otro
        if (transform.position.x > 9.5)
        {
            transform.position = new Vector2(-9.5f, Random.Range(-5, 5));
        }else if (transform.position.x < -9.5)
        {
            transform.position = new Vector2(9.5f, Random.Range(-5, 5));
        }

    }
    private void movimiento()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Traslado
            transform.position = transform.position + new Vector3(velocidad * Time.deltaTime, 0); //Debe de ser Vector3, porque sino, daria error
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Traslado
            transform.position = transform.position + new Vector3(-velocidad * Time.deltaTime, 0); //Debe de ser Vector3, porque sino, daria error
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Traslado
            transform.position = transform.position + new Vector3(0, velocidad * Time.deltaTime); //Debe de ser Vector3, porque sino, daria error
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Traslado
            transform.position = transform.position + new Vector3(0, -velocidad * Time.deltaTime); //Debe de ser Vector3, porque sino, daria error
        }
    }
}
