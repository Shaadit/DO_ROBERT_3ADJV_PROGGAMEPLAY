using UnityEngine;

namespace Bullet
{
    public class BulletModule : ScriptableObject
    {
        public Transform BulletTransform;
        public float Speed;

        public void SetSpeed(float bulletSpeed)
        {
            this.Speed = bulletSpeed;
        }

        public BulletModule(float speed, Transform bulletTransform)
        {
            this.Speed = speed;
            this.BulletTransform = bulletTransform;
        }
    }
}