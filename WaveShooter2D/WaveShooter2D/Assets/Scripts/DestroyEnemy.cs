using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Enemy(Clone)")
        {
            Destroy(other.gameObject);
            PlayerStats.score -= 1000;
        }
    }
}
