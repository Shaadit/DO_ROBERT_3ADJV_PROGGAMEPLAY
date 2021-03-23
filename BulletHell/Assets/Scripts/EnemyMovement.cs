using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;

    public float speedX;
    public float startX;
    public float height;
    
    public float speedY;
    public float startY;
    public float length;

    public float rotSpeed;
    public float rot;

    private void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time * speedX, length) + startX,
            Mathf.PingPong(Time.time * speedY, height) + startY);
        
        transform.localEulerAngles = new Vector3(0, 0, -Mathf.PingPong(Time.time * rotSpeed, rot));
    }
}
