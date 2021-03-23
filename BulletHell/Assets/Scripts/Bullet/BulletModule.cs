using UnityEngine;

namespace Bullet
{
    public class BulletModule : ScriptableObject
    {
        public Transform bulletTransform;
        public float speed;
        public Vector3 direction;

        public BulletModule(float speed, Transform bulletTransform, Vector3 direction)
        {
            this.speed = speed;
            this.bulletTransform = bulletTransform;
            this.direction = direction;
        }
        
        public void SetSpeed(float bulletSpeed)
        {
            this.speed = bulletSpeed;
        }

        
    }
}