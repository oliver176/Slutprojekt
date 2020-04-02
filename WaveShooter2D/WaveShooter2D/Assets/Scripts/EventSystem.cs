using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    float counter;
    public float powerUpSpawnRate;

    public GameObject playArea;
    MeshCollider spawnArea;
    Vector3 spawnPoint;

    public GameObject powerUp_fireRate;
    public GameObject powerUp_projectileSize;
    public GameObject powerUp_scoreMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        spawnArea = playArea.GetComponent<MeshCollider>();
        spawnPoint = spawnArea.bounds.size;  //hitta storleken av meshcollidern
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;

        if (counter < 0)
        {
            //spawna inom arean av banan, de är delade på 2 eftersom att mitten av banan är (0, 0)
            spawnPoint = new Vector3(Random.Range(-spawnArea.bounds.size.x / 2, spawnArea.bounds.size.x / 2),
                                     Random.Range(-spawnArea.bounds.size.y / 2, spawnArea.bounds.size.y / 2), 0);

            var powerUpList = new List<GameObject>
        {
            powerUp_fireRate,
            powerUp_projectileSize,
            powerUp_scoreMultiplier
        };

            Instantiate(powerUpList[Random.Range(0, powerUpList.Count)], spawnPoint, Quaternion.identity);
            counter += powerUpSpawnRate;
        }
    }
}
