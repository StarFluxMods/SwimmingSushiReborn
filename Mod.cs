using KitchenLib;
using KitchenLib.Logging.Exceptions;
using KitchenMods;
using System.Linq;
using System.Reflection;
using KitchenLib.Interfaces;
using SwimmingSushiReborn.Patches;
using SwimmingSushiReborn.Utilies;
using UnityEngine;
using KitchenLogger = KitchenLib.Logging.KitchenLogger;

namespace SwimmingSushiReborn
{
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.swimmingsushireborn";
        public const string MOD_NAME = "Swimming Sushi Reborn";
        public const string MOD_VERSION = "0.3.0";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.2.0";

        internal static AssetBundle Bundle;
        internal static KitchenLogger Logger;

        internal static readonly bool ENABLE_ADDITIONAL_LOBBY_DISHES = true;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly())
        {
        }

        protected override void OnInitialise()
        {
            Logger.LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");

            ResolveStatusChangesPatch.customProcessSets.Add(new CustomProcessResult
            {
                OriginalItemID = GDOReferences.Salmon.ID,
                OriginalResultID = GDOReferences.SalmonFillet.ID,
                HeldItemID = GDOReferences.FishKnife.ID,
                NewResultID = GDOReferences.SalmonWithRoe.ID
            });
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault() ?? throw new MissingAssetBundleException(MOD_GUID);
            Logger = InitLogger();

            // GenerateGDOReferences(Assembly.GetExecutingAssembly(), Path.Combine(Application.persistentDataPath, "GeneratedReferences.cs"));
        }
    }
}