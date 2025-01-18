using System;
using System.Collections.Generic;
using Kitchen;
using KitchenLib.References;
using KitchenMods;
using SwimmingSushiReborn.Components;
using Unity.Collections;
using Unity.Entities;

namespace SwimmingSushiReborn.Systems
{
    public class SinkSalmon : GameSystemBase, IModSystem
    {
        private EntityQuery _Salmons;

        protected override void Initialise()
        {
            base.Initialise();
            _Salmons = GetEntityQuery(new QueryHelper().All(typeof(CSalmon), typeof(CItem)));
        }

        public static int SecondsInSink = 10;
        public static int AnimationLength = 2;

        public static List<int> SinkTypes = new List<int>
        {
            ApplianceReferences.SinkLarge,
            ApplianceReferences.SinkStarting,
            ApplianceReferences.SinkNormal,
            ApplianceReferences.SinkPower,
            ApplianceReferences.SinkSoak,
        };

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> Salmons = _Salmons.ToEntityArray(Allocator.Temp))
            {
                for (var i = 0; i < Salmons.Length; i++)
                {
                    var Salmon = Salmons[i];
                    if (Require(Salmon, out CSalmon cSalmon))
                    {
                        if (Require(Salmon, out CHeldBy cHeldBy))
                        {
                            if (cHeldBy.Holder != Entity.Null && Require(cHeldBy.Holder, out CAppliance cAppliance) && SinkTypes.Contains(cAppliance.ID))
                            {
                                if (cSalmon.IsInSink)
                                {
                                    TimeSpan timeSpan = DateTime.UtcNow - cSalmon.TimePlacedInSink;
                                    if (!(timeSpan.TotalSeconds >= SecondsInSink)) continue;
                                    if (timeSpan.TotalSeconds >= SecondsInSink && timeSpan.TotalSeconds < (SecondsInSink + AnimationLength))
                                    {
                                        Set(cHeldBy.Holder, new CItemHolderPreventTransfer
                                        {
                                            PreventTakingFrom = true
                                        });
                                    }
                                    else if (timeSpan.TotalSeconds >= SecondsInSink && timeSpan.TotalSeconds >= (SecondsInSink + AnimationLength))
                                    {
                                        Unset<CItemHolderPreventTransfer>(cHeldBy.Holder);
                                        EntityManager.DestroyEntity(Salmon);
                                        // Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_SINK_SALMON);
                                    }
                                }
                                else
                                {
                                    cSalmon.IsInSink = true;
                                    cSalmon.TimePlacedInSink = DateTime.UtcNow;
                                    Set(Salmon, cSalmon);
                                }
                            }
                            else
                            {
                                cSalmon.IsInSink = false;
                                Set(Salmon, cSalmon);
                            }
                        }
                        else
                        {
                            cSalmon.IsInSink = false;
                            Set(Salmon, cSalmon);
                        }
                    }
                }
            }
        }
    }
}