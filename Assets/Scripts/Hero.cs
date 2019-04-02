using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 150f;

    public bool grounded;

    private Rigidbody2D rb2d;




    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();



    }




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }
    }
}
