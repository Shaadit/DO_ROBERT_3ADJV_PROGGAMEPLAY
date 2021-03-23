using UnityEngine;

namespace Controller
{
    public class MovementSystem : IUpdater
    {
        public void SystemUpdate()
        {
            TAccessor<MovementModule> myModuleAccessor = TAccessor<MovementModule>.Instance();
            foreach (var module in myModuleAccessor.DisplayListT())
            {
                module.playerTransform.position += new Vector3(module.speedX, module.speedY) * Time.deltaTime;
            }
        }
    }
}
