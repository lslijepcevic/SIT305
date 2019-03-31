using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject Enemy;
    float randX;
    private Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2 (11.0f, 0.08f);
            Instantiate(Enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
