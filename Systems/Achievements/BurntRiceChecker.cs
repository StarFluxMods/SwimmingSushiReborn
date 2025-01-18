using Kitchen;
using KitchenMods;
using SwimmingSushiReborn.Components;
using SwimmingSushiReborn.Utilies;
using Unity.Collections;
using Unity.Entities;

namespace SwimmingSushiReborn.Systems.Achievements
{
    public class BurntRiceChecker : RestaurantSystem, IModSystem
    {
        private EntityQuery _Items;

        protected override void Initialise()
        {
            base.Initialise();
            _Items = GetEntityQuery(new QueryHelper().All(typeof(CItem)).None(typeof(CCompletedAchievementEntity)));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> Items = _Items.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity Item in Items)
                {
                    if (!Require(Item, out CItem cItem)) continue;
                    if (cItem.ID == GDOReferences.BurntRicePot.ID)
                    {
                        EntityManager.AddComponent<CCompletedAchievementEntity>(Item);
                        // Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_BURNT_RICE);
                        return;
                    }
                }
            }
        }
    }
}