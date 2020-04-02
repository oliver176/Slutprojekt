using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private Vector3 startPos;
    public GameObject EnemySpawner;
    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; // Där fienden ska instansieras
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //y = 2sin((ysqrt(3))/2) + xsqrt3
        //y = x + sin(x)

        //counter += Time.deltaTime; //Counter som sinus funktionen använder sig av

        //transform.localPosition = startPos + new Vector3(Mathf.Sin(counter * speed), 0f, 0f); //Flyttar på fienden i en sinus kurva i x-led

        if (startPos.x <= 0)
        {
            startPos.x += 0.03f;
        }
        else if (startPos.x >= 0)
        {
            startPos.x -= 0.03f;
        }     

        startPos.y -= 0.03f;
        
        //startPos.y = startPos.x + Mathf.Sin(startPos.x); //Flytta också fienden 
       
        transform.localPosition = new Vector3(startPos.x, startPos.y, 0f);

    }
}
