using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject enemy, enemy2;



    public float timeBetweenSpawn;
    public float timeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController play = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        if (Time.time >= timeToSpawn)
        {
            timeToSpawn = Time.time + timeBetweenSpawn;
            SpawnEnemy();
        }


        void SpawnEnemy()
        {
            int rnd = Random.Range(0, spawnPoints.Length);

            for (int i = 0; i < spawnPoints.Length; i++)
            {
                if (rnd == i)
                {
                    if (play.enemyKillCount <= 6)
                    {
                        Instantiate(enemy, spawnPoints[i].position, Quaternion.identity);
                    }
                    if (play.enemyKillCount > 6 && play.enemyKillCount <= 10)
                    {
                        Instantiate(enemy2, spawnPoints[i].position, Quaternion.identity);
                    }

                }

            }

        }
    }
}
