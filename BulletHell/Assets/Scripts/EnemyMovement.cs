using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;
    public Rigidbody2D rb;
 
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), (float) 6.75);
            timeLeft += accelerationTime;
        }
    }
 
    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }
}
