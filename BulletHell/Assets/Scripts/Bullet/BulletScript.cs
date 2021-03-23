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
    private GameObject bullet;

    [SerializeField] 
    private GameObject wall;

    public float speed;

    private void Start()
    {
        bulletComponent = new BulletModule(this.speed, this.gameObject.transform);
        Modules = new List<ScriptableObject>();
        Modules.Add(bulletComponent);
        TAccessor<BulletModule>.Instance().Add(bulletComponent);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag($"Wall"))
        {
            Debug.Log("Touché");
        }
    }
}