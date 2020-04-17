using System.Collections;
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
        /*Sätter storleken på projektilen, fanns en bug om du tog en powerup som gjorde projektilerna större
                                            och sedan quitta spelet var projektilen forfarande stor.*/
        projectile.transform.localScale = new Vector3(0.3f, 0.3f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //en offset så att projektilen inte spawnar i spelaren
        projectileOffset = projectile.GetComponent<MeshRenderer>().bounds.size.y / 2;
        timer -= Time.deltaTime;

        if (timer <= 0f)  //Instantiate en projektil från Player
        {
            Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + projectileOffset, transform.position.z), Quaternion.identity);
            timer = fireRate;
        }
    }
}
