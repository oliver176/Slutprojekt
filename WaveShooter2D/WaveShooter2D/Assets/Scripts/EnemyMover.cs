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
        startPos = EnemySpawner.transform.position; // Där fienden ska instansieras
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime; //Counter som sinus funktionen använder sig av
        transform.position = startPos + new Vector3(Mathf.Sin(counter * speed), 0f, 0f); //Flyttar på fienden i en sinus kurva i x-led.
        startPos.y -= 0.02f; //Flytta också fienden nedåt
    }
}
