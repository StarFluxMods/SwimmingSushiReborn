using System.Linq;
using HarmonyLib;
using Kitchen;
using KitchenData;
using KitchenLib.Views;
using KitchenMods;
using SwimmingSushiReborn.Components;
using SwimmingSushiReborn.Utilies;
using Unity.Collections;
using Unity.Entities;

namespace SwimmingSushiReborn.Systems.Achievements
{
    public class ServeSalmonRoll : RestaurantSystem, IModSystem
    {
        private EntityQuery _WaitingForItems;
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
                    if (RequireBuffer(WaitingForItem, out DynamicBuffer<CWaitingForItem> buffer))
                    {
                        foreach (CWaitingForItem cWaitingForItem in buffer)
                        {
                            if (cWaitingForItem.ItemID == GDOReferences.PlatedSalmonRoll.ID && cWaitingForItem.Satisfied)
                            {
                                EntityManager.AddComponent<CCompletedAchievementEntity>(WaitingForItem);
                                Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_SERVE_SALMONROLL);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
    
    [HarmonyPatch(typeof(ModAchievementDistributionView), "UpdateData")]
    public class x
    {
        static void Prefix(ModAchievementDistributionView.ViewData data)
        {
            Mod.Logger.LogInfo(data.modId);
            Mod.Logger.LogInfo(data.achievementKey);
        }
    }
}