using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;

    public GameObject projectile;

    public float duration = 5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PickUp());
        }
    }
    IEnumerator PickUp()
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
