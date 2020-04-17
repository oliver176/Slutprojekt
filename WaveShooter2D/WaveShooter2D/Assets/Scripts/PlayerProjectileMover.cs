using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileMover : MonoBehaviour
{
    [SerializeField]
    float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Flytta projektilen fram/upp
        Vector2 movement = new Vector2(0, 1) * Time.deltaTime * speed;
        transform.Translate(movement);
    }
}
