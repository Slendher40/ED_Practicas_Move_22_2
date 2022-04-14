using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inteface : MonoBehaviour
{
    public Text scoreText;
    Score puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = GetComponent<Score>();
        scoreText.text = puntos.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = puntos.score.ToString();
    }
}
