using System;
using System.Collections;
using System.Collections.Generic;
using Bullet;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private List<ScriptableObject> Modules;
    public BulletModule bulletComponent;
    
    [SerializeField] 
    private Transform bullet;

    [SerializeField] 
    private GameObject wall;

    public float speed;

    private void Start()
    {
        bulletComponent = new BulletModule(speed, bullet);
        Modules = new List<ScriptableObject>();
        Modules.Add(bulletComponent);
        TAccessor<BulletModule>.Instance().Add(bulletComponent);
    }
    
}