using System;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private List<ScriptableObject> Modules;
    public GunModule gunComponent;
    [SerializeField] private BulletScript bullet;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float shotInterval;

    public bool isFiring;
    private float shotCounter;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Start()
    {
        gunComponent = new GunModule(this.isFiring, this.bullet, this.firePoint, this.bulletSpeed, this.shotInterval, this.shotCounter);
        Modules = new List<ScriptableObject>();
        Modules.Add(gunComponent);
        TAccessor<GunModule>.Instance().Add(gunComponent);
    }
}