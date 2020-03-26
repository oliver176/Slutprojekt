﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_FireRate : PowerUps
{
    PlayerStats statScript;
    public float multiplier;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        statScript = player.GetComponent<PlayerStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override IEnumerator PickUp()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        statScript.fireRate *= multiplier;

        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        statScript.fireRate /= multiplier;

        Destroy(gameObject);
    }
}
