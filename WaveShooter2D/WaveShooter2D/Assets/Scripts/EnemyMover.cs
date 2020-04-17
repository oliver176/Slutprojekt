using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private Vector3 startPos;
    private Vector3 currentPos;
    public GameObject EnemySpawner;
    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        //Variabler som representerar fiendens position
        startPos = transform.position; 
        currentPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*Counter som sinus funktionen använder sig av
        counter += Time.deltaTime; 

        Flyttar på fienden i en sinus kurva i x-led
        transform.localPosition = currentPos + new Vector3(Mathf.Sin(counter * speed), 0f, 0f); */


        //Om fienden spawnar vänster om mitten rör den sig åt höger
        if (startPos.x <= 0)
        {
            currentPos.x += 0.02f;

        }
        //Om fienden spawnar höger om mitten rör den sig åt vänster
        else if (startPos.x >= 0)
        {
            currentPos.x -= 0.02f;
        }     
        //Flytta fienden ner 
        currentPos.y -= 0.03f;

        //Flytta fienden till den nya positionen
        transform.localPosition = new Vector3(currentPos.x, currentPos.y, 0f);

    }
}
