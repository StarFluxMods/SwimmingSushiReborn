using Kitchen;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace SwimmingSushiReborn.Systems
{
    public class UnlimitedMoney : NightSystem // , IModSystem
    {
        private EntityQuery _sMoney;

        protected override void Initialise()
        {
            base.Initialise();
            _sMoney = GetEntityQuery(typeof(SMoney));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> sMoney = _sMoney.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity entity in sMoney)
                {
                    if (Require(entity, out SMoney SMoney))
                    {
                        SMoney.Amount = 9999;
                        SetComponent(entity, SMoney);
                    }
                }
            }
        }
    }
}