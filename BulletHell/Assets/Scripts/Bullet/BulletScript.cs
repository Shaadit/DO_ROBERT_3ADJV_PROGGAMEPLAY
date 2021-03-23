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
    private GameManager wall;

    public float speed;
    void FixedUpdate()
    {
        Instantiate(bullet, transform);
        
        this.bulletComponent.SetSpeed(this.speed);
        
        //bullet.transform.position += Vector3.up * (Time.deltaTime * speed);
    }

    private void Start()
    {
        bulletComponent = new BulletModule(this.speed, this.gameObject.transform);
        Modules = new List<ScriptableObject>();
        Modules.Add(bulletComponent);
        TAccessor<BulletModule>.Instance().Add(bulletComponent);
    }

    private void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }
}