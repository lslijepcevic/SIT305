using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Declare variables needed
    private bool Spawn1 = true;
    private bool Spawn2 = true;
    private bool Spawn3 = true;


    public float score;
    public float highscore;

    public GameObject Enemy;


    private float STimer;
     Vector2 whereToSpawn1;
     Vector2 whereToSpawn2;
     Vector2 whereToSpawn3;


    // Declare 3 random numbers
    void Start()
    {
        score = PlayerPrefs.GetFloat("Score");
    }




    void Update()
    {

         //If spawn for for 1 is equal to true, the is a spawn location given and an enemy is instantiated based on a timer
         //in a function above. The number above is used to set random intervals at which the enemy is spawned. The Coroutine makes
         //sure that multiple enemies are not spawned at the same time
        if (Spawn1 == true)
        {
            whereToSpawn1 = new Vector2(15.0f, -0.3f);
            Instantiate(Enemy, whereToSpawn1, transform.rotation);
            StartCoroutine(Timer());
        }


        // Same as above however spawn location is for the second row of enemies
        if (Spawn2 == true)
        {
            whereToSpawn2 = new Vector2(15.0f, 1.5f);
            Instantiate(Enemy, whereToSpawn2, transform.rotation);
            StartCoroutine(Timer2());
        }

        // Same as above however spawn location is for the third row of enemies
        if (Spawn3 == true)
        {
            whereToSpawn3 = new Vector2(15.0f, -2.1f);
            Instantiate(Enemy, whereToSpawn3, transform.rotation);
            StartCoroutine(Timer3());
        }




        score = PlayerPrefs.GetFloat("Score");
        Debug.Log(score);
        highscore = PlayerPrefs.GetFloat("HighScore");
        Debug.Log(highscore);





    }




// This function is used to set a random time time at which an enemy will spawn
// A random number is generated then spawn is set to false (so enemies cant spawn) until the counter has reached 0.
// I have set a range of 0.5 to 3.5 for the timer so an enemy will spawn in between 0.5 seconds and 3.5 seconds
IEnumerator Timer()
    {
        float number = Random.Range(0.5f, 3.50f);
        Spawn1 = false;
        yield return new WaitForSeconds(number);
        Spawn1 = true;
    }

    IEnumerator Timer2()
    {
        float number2 = Random.Range(0.5f, 3.50f);
        Spawn2 = false;
        yield return new WaitForSeconds(number2);
        Spawn2 = true;
    }

    IEnumerator Timer3()
    {
        float number3 = Random.Range(0.5f, 3.50f);
        Spawn3 = false;
        yield return new WaitForSeconds(number3);
        Spawn3 = true;
    }



    IEnumerator TimerFast()
    {
        float number4 = Random.Range(0.5f, 2.50f);
        Spawn1 = false;
        yield return new WaitForSeconds(number4);
        Spawn1 = true;
    }

    IEnumerator TimerFast2()
    {
        float number5 = Random.Range(0.5f, 2.50f);
        Spawn2 = false;
        yield return new WaitForSeconds(number5);
        Spawn2 = true;
    }

    IEnumerator TimerFast3()
    {
        float number6 = Random.Range(0.5f, 2.50f);
        Spawn3 = false;
        yield return new WaitForSeconds(number6);
        Spawn3 = true;
    }



    IEnumerator TimerFastest()
    {
        float number = Random.Range(0.2f, 1.50f);
        Spawn1 = false;
        yield return new WaitForSeconds(number);
        Spawn1 = true;
    }

    IEnumerator TimerFastest2()
    {
        float number2 = Random.Range(0.2f, 1.50f);
        Spawn2 = false;
        yield return new WaitForSeconds(number2);
        Spawn2 = true;
    }

    IEnumerator TimerFastest3()
    {
        float number3 = Random.Range(0.2f, 0.3f);
        Spawn3 = false;
        yield return new WaitForSeconds(number3);
        Spawn3 = true;
    }


}



