using Kitchen;
using KitchenMods;
using Unity.Entities;

namespace SwimmingSushiReborn.Systems
{
    public class SystemHelper : GameSystemBase, IModSystem
    {
        public static SystemHelper Instance;

        protected override void Initialise()
        {
            base.Initialise();
            Instance = this;
        }

        public bool IsUserHoldingItem(int holdingItemId, Entity user)
        {
            if (!Require(user, out CItemHolder cItemHolder) || !Require(user, out CToolUser cToolUser)) return false;

            if (cItemHolder.HeldItem != Entity.Null)
            {
                if (!Require(cItemHolder.HeldItem, out CItem cItem)) return false;
                if (cItem.ID == holdingItemId)
                {
                    return true;
                }
            }
            else if (cToolUser.CurrentTool != Entity.Null)
            {
                if (!Require(cToolUser.CurrentTool, out CItem cItem)) return false;
                if (cItem.ID == holdingItemId)
                {
                    return true;
                }
            }

            return false;
        }

        protected override void OnUpdate()
        {
        }
    }
}