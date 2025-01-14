using KitchenData;
using KitchenMods;
using Unity.Entities;

namespace SwimmingSushiReborn.Components
{
    public struct CFishDisplayBoardView : IComponentData, IApplianceProperty, IModComponent
    {
        public bool isBeingInteractedWith;
        public int interactCount;
    }
}