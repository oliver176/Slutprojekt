using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;

    public float duration = 5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        //När spelaren colliderar med powerUp
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PickUp());
        }
    }
    //Spawna en pickupeffekt och disabla poweruppen, destroy efter 5 sekunder
    protected virtual IEnumerator PickUp()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        Destroy(gameObject);
    }
}
