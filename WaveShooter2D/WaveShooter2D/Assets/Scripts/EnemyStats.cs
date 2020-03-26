using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int scoreToReceive = 250;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "PlayerProjectile(Clone)")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            PlayerStats.score += scoreToReceive;
        }
    }
}
