using UnityEngine;

namespace Bullet
{
    public class BulletModule : ScriptableObject
    {
        public Transform bulletTransform;
        public float speed;
        
        public BulletModule(float speed, Transform bulletTransform)
        {
            this.speed = speed;
            this.bulletTransform = bulletTransform;
        }
        
        public void SetSpeed(float bulletSpeed)
        {
            this.speed = bulletSpeed;
        }

        
    }
}