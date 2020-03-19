using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float spawnrate;
    private float timer;
    private Vector3 startPos;

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
            Instantiate(Enemy, startPos, Quaternion.identity);
            timer = spawnrate;
        }
    }
}