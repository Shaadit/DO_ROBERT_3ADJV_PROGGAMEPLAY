using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    List<ScriptableObject> Modules;
    public MovementModule movementComponent;
    
    public Vector2 speed = new Vector2(50, 50);

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        
        this.movementComponent.SetSpeedX(speed.x * inputX);
        this.movementComponent.SetSpeedY(speed.y * inputY);
    }

    private void Start()
    {
        movementComponent =
            new MovementModule(speed.x * Input.GetAxis("Horizontal"), speed.y * Input.GetAxis("Vertical"), this.gameObject.transform);
        
        Modules = new List<ScriptableObject>();
        Modules.Add(movementComponent);
        TAccessor<MovementModule>.Instance().Add(movementComponent);
    }
}
