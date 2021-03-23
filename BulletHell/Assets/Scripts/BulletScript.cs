using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField] 
    private GameObject bullet;

    [SerializeField] 
    private GameManager wall;

    public float speed;
    void FixedUpdate()
    {
        Instantiate(bullet, transform);
        
        bullet.transform.position += Vector3.up * (Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }
}
