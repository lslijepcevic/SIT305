using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    // NOTE: Overall this operates in a similar manner to the spawner for enemies. 

    // Declare variables 
    private bool Spawn1 = true;
    private bool Spawn2 = true;
    private bool Spawn3 = true;

    public GameObject Platform;

    private float STimer;
    Vector2 whereToSpawn1;
    Vector2 whereToSpawn2;
    Vector2 whereToSpawn3;



    void Start()
    {

    }

    void Update()
    {

        // If spawn for for 1 is equal to true, the is a spawn location given and an platform is instantiated based on a timer
        // in a function above. The number above is used to set random intervals at which the platform is spawned. The Coroutine makes
        // sure that multiple platforms are not spawned at the same time
        if (Spawn1 == true)
        {
            whereToSpawn1 = new Vector2(15.0f, -0.9f);
            Instantiate(Platform, whereToSpawn1, transform.rotation);
            StartCoroutine(Timer());
        }

        if (Spawn2 == true)
        {
            whereToSpawn2 = new Vector2(15.0f, 0.9f);
            Instantiate(Platform, whereToSpawn2, transform.rotation);
            StartCoroutine(Timer2());
        }

        if (Spawn3 == true)
        {
            whereToSpawn3 = new Vector2(15.0f, 2.7f);
            Instantiate(Platform, whereToSpawn3, transform.rotation);
            StartCoroutine(Timer3());
        }




    }



    // This function is used to set a random time time at which an enemy will spawn
    // A random number is generated then spawn is set to false (so enemies cant spawn) until the counter has reached 0.
    // I have set a range of 0.5 to 3.5 for the timer so an enemy will spawn in between 0.5 seconds and 3.5 seconds
    IEnumerator Timer()
    {
        float number = Random.Range(2.0f, 3.50f);
        Spawn1 = false;
        yield return new WaitForSeconds(number);
        Spawn1 = true;
    }

    IEnumerator Timer2()
    {
        float number2 = Random.Range(2.5f, 5.50f);
        Spawn2 = false;
        yield return new WaitForSeconds(number2);
        Spawn2 = true;
    }

    IEnumerator Timer3()
    {
        float number3 = Random.Range(2.0f, 6.50f); 
        Spawn3 = false;
        yield return new WaitForSeconds(number3);
        Spawn3 = true;
    }

}
