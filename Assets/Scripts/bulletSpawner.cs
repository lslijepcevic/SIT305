using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletSpawner : MonoBehaviour
{

    // Declare variables
    public GameObject Bullet;
    private Vector2 spawnPoint;
    float randX;
    private Vector2 whereToSpawn;
    public float spawnRate = 2f;




    private void Start()
    {

    }


    private void Update()
    {

    }



    // Spawns a bullet in front of the hero. It is instantiated 1 unit along the x axis in front of the hero. This is shown in the 
    // instantiate method below the debug. 
    public void spawnBullet()
    {
        GameObject temp = GameObject.Find("hero");
        Transform heroTransform = temp.GetComponent<Transform>();

        Debug.Log("You have clicked the button!");
       
        Instantiate(Bullet, new Vector3(heroTransform.transform.position.x + 1, heroTransform.transform.position.y, heroTransform.transform.position.z), Quaternion.identity);
    }






}
