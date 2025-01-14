using Kitchen;
using KitchenMods;
using SwimmingSushiReborn.Components;
using Unity.Entities;

namespace SwimmingSushiReborn.Systems
{
    [UpdateInGroup(typeof(LowPriorityInteractionGroup))]
    public class SlapFish : ItemInteractionSystem, IModSystem
    {
        protected override bool IsPossible(ref InteractionData data)
        {
            return Require(data.Target, out cFishDisplayBoardView);
        }

        protected override void Perform(ref InteractionData data)
        {
            if (cFishDisplayBoardView.isBeingInteractedWith) return;
            cFishDisplayBoardView.isBeingInteractedWith = true;
            cFishDisplayBoardView.interactCount++;

            if (cFishDisplayBoardView.interactCount >= 50)
            {
                Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_SLAP_FISH);
                cFishDisplayBoardView.interactCount = 0;
            }

            Set(data.Target, cFishDisplayBoardView);
        }

        private CFishDisplayBoardView cFishDisplayBoardView;
    }
}