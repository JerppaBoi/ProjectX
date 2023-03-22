using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;


    private float nextSpawn = 0.15f;
    private float spawnDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 30)
        {
            spawnDelay = 0.9f;
        }
        if(Time.time > 60)
        {
            spawnDelay = 0.8f;
        }
        if (Time.time > 90)
        {
            spawnDelay = 0.7f;
        }
        if (Time.time > 120)
        {
            spawnDelay = 0.6f;
        }
        if (Time.time > 150)
        {
            spawnDelay = 0.5f;
        }

        int option = Random.Range(0, 4);

        if (option == 0)
        {
            transform.position = new Vector2(-10, Random.Range(-7, 7));
        }
        else if (option == 1)
        {
            transform.position = new Vector2(20, Random.Range(-7, 7));
        }
        else if (option == 2)
        {
            transform.position = new Vector2(Random.Range(-10, 10), 7);
        }
        else
        {
            transform.position = new Vector2(Random.Range(10, 10), 7);
        }
    }

    private void FixedUpdate()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (Time.time > nextSpawn)
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            nextSpawn = Time.time + spawnDelay;
        }
    }

    
}
