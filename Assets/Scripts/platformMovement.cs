using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    private float inputDirection;
    private int health = 1;
    Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (health == 0)
        {
         Destroy(gameObject);
        }

    }


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


   
    // Moves the platform towards the hero and destroyer at a rate of -5 along the x axis. 
    void Update()
    {


        if (health==1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-5, 0, 0);
        }


    }
}
