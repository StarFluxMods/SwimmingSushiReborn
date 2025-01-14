using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using KitchenMods;
using SwimmingSushiReborn.Customs.PlayerCosmetics;

namespace SwimmingSushiReborn.Systems
{
    public class UnlockableCosmetics : GameSystemBase, IModSystem
    {
        private static List<PlayerCosmetic> Cosmetics = new List<PlayerCosmetic>
        {
            (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<JapaneseBandana>().GameDataObject,
            (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<NigiriCostume>().GameDataObject,
        };

        public static UnlockableCosmetics instance;
        
        protected override void Initialise()
        {
            base.Initialise();
            instance = this;
            SetupCosmetics();
        }

        protected override void OnUpdate()
        {
            
        }

        public void SetupCosmetics()
        {
            foreach (PlayerCosmetic cosmetic in Cosmetics)
            {
                cosmetic.DisableInGame = !Mod.achievementsManager.GetAchievement(Mod.ACHIEVEMENT_SERVE_SALMONROLL).HasCompleted;
            }
        }
    }
}