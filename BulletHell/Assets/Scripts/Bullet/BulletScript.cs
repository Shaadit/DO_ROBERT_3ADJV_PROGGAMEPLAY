using System;
using System.Collections;
using System.Collections.Generic;
using Bullet;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private List<ScriptableObject> Modules;
    public BulletModule bulletComponent;

    public bool shootDown;

    [SerializeField] 
    private Transform bullet;

    [SerializeField] 
    private GameObject wall;

    public float speed;

    private void Start()
    {
        Vector3 direction = shootDown == false ? Vector3.up : Vector3.down;
        bulletComponent = new BulletModule(speed, bullet, direction);
        Modules = new List<ScriptableObject>();
        Modules.Add(bulletComponent);
        TAccessor<BulletModule>.Instance().Add(bulletComponent);
    }
}