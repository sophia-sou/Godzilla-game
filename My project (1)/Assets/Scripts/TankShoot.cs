using UnityEngine;

public class TankShoot : MonoBehaviour
{
    private float timeBetweenShots;
    public float startShotTime;
    public GameObject tankLaser;

    void Start()
    {
        timeBetweenShots = startShotTime;
    }

    void Update()
    {
        if(timeBetweenShots <= 0)
        {
            //instantiate at enemy's (tank) current position
            //no roatation
            Instantiate(tankLaser, transform.position, Quaternion.identity);
            timeBetweenShots = startShotTime;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime; //each frame we get closer to shoot time
        }
    }
}
