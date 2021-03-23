using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GunSystem : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<GunModule> moduleAccessor = TAccessor<GunModule>.Instance();
        foreach (var module in moduleAccessor.DisplayListT())
        {
            if (module.isFiring)
            {
                module.shotCounter -= Time.deltaTime;
                if (module.shotCounter < 0.5f)
                {
                    module.shotCounter = module.shotInterval;
                    BulletScript newBullet = MonoBehaviour.Instantiate(module.bullet, module.firePoint.position, module.firePoint.rotation);
                    newBullet.speed = module.bulletSpeed;
                }
            }
            
            
            
        }
        
    }
}