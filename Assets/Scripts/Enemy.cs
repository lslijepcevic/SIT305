using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float inputDirection;
    private int health = 1;


    // Use this for initialization
    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {
        //inputDirection = Input.GetAxis("Horizontal");

        //moveVector = new Vector3(inputDirection,0,0);
        if (health==1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-5, 0, 0);
        }
    }

}
// myTranform.position = new Vector3(11, 0.08f, 0);
