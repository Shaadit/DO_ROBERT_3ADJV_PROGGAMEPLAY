using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        List<ScriptableObject> _modules;
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
        
            _modules = new List<ScriptableObject>();
            _modules.Add(movementComponent);
            TAccessor<MovementModule>.Instance().Add(movementComponent);
        }
    }
}
