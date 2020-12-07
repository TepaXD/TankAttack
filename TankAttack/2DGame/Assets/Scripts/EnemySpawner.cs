using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnTimer = 0.5f;
    public int minDistance = 15;
    public int spawnPoint;
    public int enemy;
    float nextSpawn = 0.0f;

    public Transform playerTransform;
    public GameObject[] spawnPoints;
    public GameObject[] enemies;

   
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    void Update()
    {
        int spawnPoint = Random.Range(0, spawnPoints.Length);
        int enemy = Random.Range(0, enemies.Length);

        if (!PlayerManager.isDead)
        {
            if (Time.time > nextSpawn)
            {
                Instantiate(enemies[enemy], spawnPoints[spawnPoint].transform.position, Quaternion.identity);
                nextSpawn = Time.time + spawnTimer;
            }

        }
    }

}
