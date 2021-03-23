using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Bullet
{
    public class BulletSystem : IUpdater

    {
    public void SystemUpdate()
    {
        TAccessor<BulletModule> moduleAccessor = TAccessor<BulletModule>.Instance();
        foreach (var module in moduleAccessor.DisplayListT())
        {
            module.BulletTransform.position += Vector3.up * (Time.deltaTime * module.Speed);
        }
    }
    }
}