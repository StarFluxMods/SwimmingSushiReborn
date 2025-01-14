using Kitchen;
using KitchenMods;
using SwimmingSushiReborn.Components;
using Unity.Collections;
using Unity.Entities;

namespace SwimmingSushiReborn.Systems
{
    public class CleanFishSlapping : StartOfNightSystem, IModSystem
    {
        private EntityQuery _FishBoards;

        protected override void Initialise()
        {
            base.Initialise();
            _FishBoards = base.GetEntityQuery(typeof(CFishDisplayBoardView), typeof(CLinkedView));
        }
        protected override void OnUpdate()
        {
            using (NativeArray<Entity> FishBoards = _FishBoards.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity FishBoard in FishBoards)
                {
                    if (Require(FishBoard, out CFishDisplayBoardView cFishDisplayBoardView))
                    {
                        cFishDisplayBoardView.interactCount = 0;
                        Set(FishBoard, cFishDisplayBoardView);
                    }
                }
            }
        }
    }
}