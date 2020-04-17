using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        //När en enemy slår i, förlora 1000 score.
        if (other.gameObject.name == "Enemy(Clone)")
        {
            Destroy(other.gameObject);
            PlayerStats.score -= 1000;
        }
    }
}
