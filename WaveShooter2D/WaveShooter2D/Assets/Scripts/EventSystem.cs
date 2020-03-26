using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public GameObject powerUp;
    float counter;
    public float powerUpSpawnRate;

    public GameObject playArea;
    MeshCollider spawnArea;
    Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        List<PowerUps> powerUpList = new List<PowerUps>();


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

            Instantiate(powerUp, spawnPoint, Quaternion.identity);
            counter += powerUpSpawnRate;
        }
    }
}
