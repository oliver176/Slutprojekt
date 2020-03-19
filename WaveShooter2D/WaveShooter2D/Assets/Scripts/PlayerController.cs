using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    float speed = 3;

    public float fireRate = 0.1f;

    private float timer;

    public static int score;

    public GameObject projectile;

    void Start()
    {
        
    }

    void Update()
    {
        timer -= Time.deltaTime;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical) * Time.deltaTime * speed; 

        transform.Translate(movement);

        if (timer <= 0f)  //Instantiate en projektil mitt på gameObjectet
        {
            Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.identity);
            timer = fireRate;
        }
    }
}
