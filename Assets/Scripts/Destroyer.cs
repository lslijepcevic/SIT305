using UnityEngine;



public class Destroyer : MonoBehaviour  {
    Rigidbody2D rb;


    // Destroys and object on contact, used to kill all enemies that go off screen.
    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }
}

