using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GodzillaMovement : MonoBehaviour
{
    public float godzilla_xSpeed;
    public float godzilla_xSprint;
    public float godzilla_ySpeed;
    public float godzilla_ySprint;


    public Rigidbody2D rb;
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");


        Vector2 direction = new Vector2(xInput, yInput).normalized;

        float xSpeed;
        float ySpeed;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            xSpeed = godzilla_xSprint;
            ySpeed = godzilla_ySprint;
        }
        else
        {
            xSpeed = godzilla_xSpeed;
            ySpeed = godzilla_ySpeed;
        }

        Vector2 velocity = new Vector2(direction.x*xSpeed, direction.y*ySpeed);

        rb.linearVelocity = velocity;
    }
}
