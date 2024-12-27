using Unity.Hierarchy;
using UnityEngine;

public class FireBallMovement : MonoBehaviour
{
    public float fireSpeed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.linearVelocity =  transform.right * fireSpeed;   
    }
}
