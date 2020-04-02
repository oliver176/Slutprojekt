using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_ProjectileSize : PowerUp
{
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override IEnumerator PickUp()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        projectile.transform.localScale = projectile.transform.localScale * 2;

        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        projectile.transform.localScale = projectile.transform.localScale / 2;

        Destroy(gameObject);
    }
}
