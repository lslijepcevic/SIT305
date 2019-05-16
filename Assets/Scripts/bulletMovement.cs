using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletMovement : MonoBehaviour
{

    // Declared variables
    private float inputDirection;
    private float number; 
    private int health = 1;
    Rigidbody2D rb;
    bool timerUp;
    int seconds = 2;
    float velX = 5.0f;
    float velY = 0.0f;


    // On collision enter, the bullet destroys itself and the other game object that it collides with. 
    private void OnTriggerEnter2D(Collider2D col)
    {
        health = health - 1;
        if (health == 0)
        {
            Destroy(col.gameObject);
            Destroy(gameObject);

        }
    }

    // If the bullet collides with one of the platforms with the tag of floor, it will destroy itself
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "floor")
        {
            Destroy(gameObject);
        }


    }


    // Start is called before the first frame update
    // Gets the rigidbody of the bullet and translates it across the x axis while health is equal to 1. On collision
    // its health falls to 0. This is in the OnTriggerEnter2D method.
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        rb.velocity = new Vector2();
        if (health == 1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(10, 0, 0);
        }
    }

    // Destorys the bullet after 2 seconds (in case it got past everything). Wouldn't like a bunch of bullets
    // flying in the distance using up memory and slowing the game down. 
    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {


    }




}
