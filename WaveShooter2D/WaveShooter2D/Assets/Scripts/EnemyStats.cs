using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int scoreToReceive = 250;



    void OnCollisionEnter2D(Collision2D other)
    {
        //Om fienden träffas av spelarens skott ge spelaren score
        if (other.gameObject.name == "PlayerProjectile(Clone)")
        {
            Destroy(other.gameObject);

            Destroy(gameObject);
            PlayerStats.score += scoreToReceive;
        }
    }
}
