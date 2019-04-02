﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private Hero hero;

   
    void Start()
    {
        hero = gameObject.GetComponentInParent<Hero>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        hero.grounded = true;
        Debug.Log("collide");
        Destroy(col.gameObject);
        hero.grounded = true;
    }

    void OnTriggerStay2D(Collider other)
    {
        hero.grounded = true;
        Debug.Log("collide");
    }

    private void OnTriggerExit2D(Collider other)
    {
        hero.grounded = false; 
    }


}
