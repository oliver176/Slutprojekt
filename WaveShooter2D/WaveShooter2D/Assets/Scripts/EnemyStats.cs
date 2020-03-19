using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "PlayerProjectile(Clone)")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            PlayerStats.score += 250;
        }
    }
}
