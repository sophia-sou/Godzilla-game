using Unity.Hierarchy;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FireBallMovement : MonoBehaviour
{
    //public GameObject firePoint;
    public float fireSpeed = 20f;
    public Rigidbody2D rb;
    public int ii = 1;
    //public Transform frbtr;

    void Start()
    { //rb.linearVelocity = transform.right * fireSpeed;
       
        
        float xInput = Input.GetAxisRaw("Horizontal");
        Vector3 localScale = transform.localScale;
        //Debug.Log(frbtr.localScale.x);

        //Debug.Log(firePoint.transform.rotation.x);
        if (xInput==1)
        {
            
            rb.linearVelocity = transform.right * fireSpeed;
        }
        else if (xInput==-1)
        {
            
            rb.linearVelocity = -transform.right * fireSpeed;
        }
        else if (xInput == 0 && localScale.x == 1)
        {
            rb.linearVelocity = transform.right * fireSpeed;
            Debug.Log(localScale.x);
        }
        else if (xInput == 0 && localScale.x == -1)
        {
            rb.linearVelocity = transform.right * fireSpeed;
            Debug.Log(localScale.x);
        }
    }


   
}

