using System;
using KitchenData;
using KitchenMods;
using Unity.Entities;

namespace SwimmingSushiReborn.Components
{
    public struct CSalmon : IComponentData, IModComponent, IItemProperty
    {
        public DateTime TimePlacedInSink;
        public bool IsInSink;
    }
}