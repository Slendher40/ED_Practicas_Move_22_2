using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {

	rb2D.AddForce(Vector3.left * 5000);

	}
    }
}
