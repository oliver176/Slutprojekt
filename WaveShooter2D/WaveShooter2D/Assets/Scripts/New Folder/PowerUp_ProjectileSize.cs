using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_ProjectileSize : PowerUp
{
    public GameObject projectile;

    protected override IEnumerator PickUp()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //öka projektilen size
        projectile.transform.localScale = projectile.transform.localScale * 2;

        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        //reset projektilen size
        projectile.transform.localScale = projectile.transform.localScale / 2;

        Destroy(gameObject);
    }
}
