using UnityEngine;



public class HelicopterDestraction : MonoBehaviour
{//DEN DOYLEYEI
    public GameObject fireball;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name==fireball.name)
        {
            Debug.Log("mlkkkkk");
        }
    }


}
