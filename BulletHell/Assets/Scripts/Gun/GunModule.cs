using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunModule : ScriptableObject
{
    public bool isFiring;
    public BulletScript bullet;
    public Transform firePoint;
    public float bulletSpeed;
    public float shotInterval;
    public float shotCounter;

    public void SetBulletSpeed(float bulletSpeed)
    {
        this.bulletSpeed = bulletSpeed;
    }

    public void SetShotInterval(float shotInterval)
    {
        this.shotInterval = shotInterval;
    }
    
    public void SetShotCounter(float shotCounter)
    {
        this.shotCounter = shotCounter;
    }

    public GunModule(bool isFiring, BulletScript bullet, Transform firePoint, float bulletSpeed, float shotInterval, float shotCounter)
    {
        this.isFiring = isFiring;
        this.bullet = bullet;
        this.firePoint = firePoint;
        this.bulletSpeed = bulletSpeed;
        this.shotInterval = shotInterval;
        this.shotCounter = shotCounter;
    }
}