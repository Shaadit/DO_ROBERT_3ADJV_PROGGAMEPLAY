using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private BulletScript bullet;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float shotInterval;

    public bool isFiring;
    private float shotCounter;
    

    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = shotInterval;
                BulletScript newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletScript;
                newBullet.speed = bulletSpeed;
            }
        }
    }
}
