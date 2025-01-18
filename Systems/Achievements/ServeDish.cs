using System.Collections.Generic;
using System.Linq;
using Kitchen;
using KitchenMods;
using SwimmingSushiReborn.Components;
using SwimmingSushiReborn.Utilies;
using Unity.Collections;
using Unity.Entities;

namespace SwimmingSushiReborn.Systems.Achievements
{
    public class ServeDish : RestaurantSystem, IModSystem
    {
        private EntityQuery _WaitingForItems;

        private static Dictionary<int, string> DishAchievementKeypair = new Dictionary<int, string>
        {
            { GDOReferences.PlatedSalmonRoll.ID, Mod.ACHIEVEMENT_SERVE_SALMONROLL }
        };

        protected override void Initialise()
        {
            base.Initialise();
            _WaitingForItems = GetEntityQuery(new QueryHelper().All(typeof(CWaitingForItem)).None(typeof(CCompletedAchievementEntity)));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> WaitingForItems = _WaitingForItems.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity WaitingForItem in WaitingForItems)
                {
                    if (!RequireBuffer(WaitingForItem, out DynamicBuffer<CWaitingForItem> buffer)) continue;
                    foreach (var cWaitingForItem in buffer.Where(cWaitingForItem => DishAchievementKeypair.ContainsKey(cWaitingForItem.ItemID) && cWaitingForItem.Satisfied))
                    {
                        EntityManager.AddComponent<CCompletedAchievementEntity>(WaitingForItem);
                        // Mod.achievementsManager.UnlockAchievement(DishAchievementKeypair[cWaitingForItem.ItemID]);
                        return;
                    }
                }
            }
        }
    }
}