using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float inputDirection;
    private int health = 1;
    Rigidbody2D rb;


    // Destroys the hero on contact
    private void OnTriggerEnter2D(Collider2D col)
    {
        health = health - 1;
        if (health == 0)
        {
         Destroy(gameObject);
        }

    }


    // Get rigidbody of enemy so that we can manipulate movement
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {
        // As long as the enemy is alive (with health of 1) it will move along the x axis from right to left
        // The rigidbody translates along the x axis at a velocity of -7.
        if (health==1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-7, 0, 0);
        }


    }

}
