using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementModule : ScriptableObject
{
    public float speedX;
    public float speedY;
    public Transform playerTransform;

    public void SetSpeedX(float speedX)
    {
        this.speedX = speedX;
    }
    
    public void SetSpeedY(float speedY)
    {
        this.speedY = speedY;
    }

    public MovementModule(float speedX, float speedY, Transform playerTransform)
    {
        this.speedX = speedX;
        this.speedY = speedY;
        this.playerTransform = playerTransform;
    }
}
