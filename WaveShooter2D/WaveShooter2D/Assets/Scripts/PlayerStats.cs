﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float fireRate = 0.1f;

    private float timer;

    public static int score;

    public GameObject projectile;

    float projectileOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        projectileOffset = projectile.GetComponent<MeshRenderer>().bounds.size.y / 2;
        timer -= Time.deltaTime;

        if (timer <= 0f)  //Instantiate en projektil från Player
        {
            Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + projectileOffset, transform.position.z), Quaternion.identity);
            timer = fireRate;
        }
    }
}