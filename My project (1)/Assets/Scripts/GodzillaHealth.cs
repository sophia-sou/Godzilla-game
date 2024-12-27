using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GodzillaHealth : MonoBehaviour
{
    Rigidbody rb;

    // starting health value
    public int health = 100;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);

        // decrease health if collision with bullet (Laser To Be) 
        if (other.gameObject.CompareTag("bullet"))
        {
            health -= 10;
            Debug.Log("Godzilla hit by bullet! Health: " + health);

            if (health <= 0)
            {
                health = 0;
                Debug.Log("Godzilla is dead!");
            }
        }
        // die if collision with other
        
        if (other.gameObject.CompareTag("enemy"))
        {
            health = 0;
            Debug.Log("Godzilla hit by tank or helicopter! Health: " + health);
        }
    }
}
