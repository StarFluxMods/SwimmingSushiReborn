using KitchenData;
using KitchenLib.Customs;

namespace SwimmingSushiReborn.Customs.Generic
{
    public abstract class GenericFoodItemGroup : CustomItemGroup
    {
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}