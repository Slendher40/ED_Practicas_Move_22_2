using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Time.time mide el tiempo transcurrido en segundos desde el Start

public class Posicion : MonoBehaviour
{
    public float velocidad;
    public float gravedad;

    public Transform camara;

    Vector3 offset;
    void Start()
    {
        //posicionamiento
        transform.position = new Vector2(0, 0);
        camara.position = new Vector3(0, 0, -10);
        offset = transform.position + camara.position;
    }

    void Update()
    {
        //movimiento();
        movimiento2();

        teleportacion();

        //Intentando simular algun tipo de gravedad
        /*if (transform.position.y > -5)
        {
            transform.position = transform.position + new Vector3(0, -gravedad * Time.deltaTime);
        }*/

        camara.transform.position = offset + transform.position;


    }
    private void movimiento() //usando transform.position + vector
    {
        //Time.deltaTime es el intervalo en segundo desde el ultimo frame hasta el actual
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

    private void movimiento2() //usando transform.Translate
    {
        //transform.Translate(Vector3.left); //Accion de traslado, por defecto tiene un valor de velocidad de 1
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Traslado
            transform.Translate(Vector3.right * Time.deltaTime * velocidad);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Traslado
            transform.Translate(Vector3.left * Time.deltaTime * velocidad);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Traslado
            transform.Translate(Vector3.up * Time.deltaTime * velocidad);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Traslado
            transform.Translate(Vector3.down * Time.deltaTime * velocidad);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //Rotacion
            transform.Rotate(Vector3.forward * Time.deltaTime * velocidad, 1);
        }

    }

    private void teleportacion()
    {
        //"Teletransportacion" de un lado de la pantalla al otro
        if (transform.position.x > 9.5)
        {
            transform.position = new Vector2(-9.5f, Random.Range(-5f, 5f));
            //Random.Range da un valor random Random.Range(ValMin, ValMax)
        }
        else if (transform.position.x < -9.5)
        {
            transform.position = new Vector2(9.5f, Random.Range(-5f, 5f));
        }
        if (transform.position.y > 5.5)
        {
            transform.position = new Vector2(transform.position.x, -5.5f);
        }
        else if (transform.position.y < -5.5)
        {
            transform.position = new Vector2(transform.position.x, 5.5f);
        }
    }
}
