using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Score : PowerUps
{
    public GameObject enemy;
    EnemyStats scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = enemy.GetComponent<EnemyStats>();
    }

    protected override IEnumerator PickUp()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        scoreScript.scoreToReceive *= 2;

        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        scoreScript.scoreToReceive /= 2;

        Destroy(gameObject);
    }
}
