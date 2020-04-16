using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float spawnrate;
    private float timer;
    private Vector3 startPos;

    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;


    // Start is called before the first frame update
    private void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            var spawnPointsList = new List<GameObject>
            {
            spawnPoint1,
            spawnPoint2,
            spawnPoint3,
            spawnPoint4
            };
            //Instantiate(Enemy, startPos, Quaternion.identity);
            Instantiate(Enemy, spawnPointsList[Random.Range(0, 3)].transform.position, Quaternion.identity);
            timer = spawnrate;
        }
    }
}