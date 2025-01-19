using System;
using System.Collections.Generic;
using System.IO;
using KitchenLib;
using KitchenLib.Logging.Exceptions;
using KitchenMods;
using System.Linq;
using System.Reflection;
using KitchenData;
using KitchenLib.Achievements;
using KitchenLib.Event;
using KitchenLib.Interfaces;
using KitchenLib.Utils;
using SwimmingSushiReborn.Patches;
using SwimmingSushiReborn.Utilies;
using TMPro;
using UnityEngine;
using KitchenLogger = KitchenLib.Logging.KitchenLogger;

// https://poly.pizza/m/1O5Q4pE8X6e - Crab Body
// https://poly.pizza/m/6Mkzj62qX2d - Crab Arm
// https://free3d.com/3d-model/saltwater-aquarium-v1--172967.html - Fish Tank
// https://www.freepik.com/free-vector/branch-cherry-blossom-background_3917958.htm#fromView=keyword&page=1&position=2&uuid=e7d99d62-a61f-4ce9-8178-94ea166d8f29&new_detail=true - Cherry Blossoms
// https://uxwing.com/crab-icon/ - Crab Icon (Not Attr)

namespace SwimmingSushiReborn
{
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.swimmingsushireborn";
        public const string MOD_NAME = "Swimming Sushi Reborn";
        public const string MOD_VERSION = "0.1.4";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.2.0";

        internal static AssetBundle Bundle;
        internal static KitchenLogger Logger;

        internal static AchievementsManager achievementsManager;

        internal static readonly bool ENABLE_ADDITIONAL_LOBBY_DISHES = false;

        internal static readonly string ACHIEVEMENT_SERVE_SALMONROLL = "ACHIEVEMENT_SERVE_SALMONROLL";
        internal static readonly string ACHIEVEMENT_SPECIAL_KNIFE = "ACHIEVEMENT_SPECIAL_KNIFE";
        internal static readonly string ACHIEVEMENT_BURNT_RICE = "ACHIEVEMENT_BURNT_RICE";
        internal static readonly string ACHIEVEMENT_SLAP_FISH = "ACHIEVEMENT_SLAP_FISH";
        internal static readonly string ACHIEVEMENT_SINK_SALMON = "ACHIEVEMENT_SINK_SALMON";

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

            achievementsManager = new AchievementsManager(MOD_GUID, MOD_NAME);
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_SERVE_SALMONROLL, "Salmon Sensations", "Serve a Salmon Roll to a customer.", Bundle.LoadAsset<Texture2D>("SalmonRollIcon")));
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_SPECIAL_KNIFE, "Specialty  Knife?", "Use a Fish Knife to get Roe from a Salmon", Bundle.LoadAsset<Texture2D>("SpecialityKnifeIcon")));
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_BURNT_RICE, "You had so much time...", "Manage to burn a Rice Pot", Bundle.LoadAsset<Texture2D>("BurntRicePotIcon")));
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_SLAP_FISH, "Okay! We get it!", "Slap a Mounted Fish 100 times in a single day", Bundle.LoadAsset<Texture2D>("FishSlapIcon")).SetHidden(true));
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_SINK_SALMON, "Where'd It Go?", "Leave a Salmon in the sink for too long.", Bundle.LoadAsset<Texture2D>("SalmonSinkIcon")).SetHidden(true));

            achievementsManager.Load();
            achievementsManager.Save();

            Bundle.LoadAllAssets<Texture2D>();
            Bundle.LoadAllAssets<Sprite>();
            var spriteAsset = Bundle.LoadAsset<TMP_SpriteAsset>("RollIcon");
            TMP_Settings.defaultSpriteAsset.fallbackSpriteAssets.Add(spriteAsset);
            spriteAsset.material = GameObject.Instantiate(TMP_Settings.defaultSpriteAsset.material);
            spriteAsset.material.mainTexture = Bundle.LoadAsset<Texture2D>("Tex_RollIcon");

            Events.BuildGameDataEvent += (sender, args) =>
            {
                foreach (Appliance appliance in args.gamedata.Get<Appliance>())
                {
                    if (appliance.Processes is not { Count: > 0 }) continue;
                    foreach (var process in appliance.Processes.Where(process => process.Process == GDOReferences.Knead))
                    {
                        appliance.Processes.Add(new Appliance.ApplianceProcesses
                        {
                            Process = GDOReferences.Roll,
                            IsAutomatic = process.IsAutomatic,
                            Speed = process.Speed,
                            Validity = process.Validity
                        });
                        break;
                    }
                }
            };

            AddOptionalCraneCosmetics();


            // RefGenerator.GenerateGDOReferences(Assembly.GetExecutingAssembly(), Path.Combine(Application.persistentDataPath, "GeneratedReferences.cs"));
        }

        private void AddOptionalCraneCosmetics()
        {
            foreach (Type type in ModPreload.Mods.SelectMany(mod => from pack in mod.GetPacks<AssemblyModPack>() from type in pack.Asm.GetTypes() where type.Name == "CustomCraneCosmetic" select type))
            {
                var craneCosmeticTypeEnum = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(assembly => assembly.GetTypes())
                    .FirstOrDefault(type => type.Name == "CraneCosmeticType");

                AddGameDataObjectAutomatically(DynamicGDOBuilder.CreateDynamicGDO(type, "NigiriCraneHead", new Dictionary<(Type, string), object>
                {
                    { (craneCosmeticTypeEnum, "CosmeticType"), 1 },
                    { (typeof(GameObject), "Prefab"), Bundle.LoadAsset<GameObject>("NigiriCraneHead").AssignMaterialsByNames() },
                    { (typeof(bool), "HideOriginal"), true }
                }));

                AddGameDataObjectAutomatically(DynamicGDOBuilder.CreateDynamicGDO(type, "NigiriChain", new Dictionary<(Type, string), object>
                {
                    { (craneCosmeticTypeEnum, "CosmeticType"), 2 },
                    { (typeof(GameObject), "Prefab"), Bundle.LoadAsset<GameObject>("NigiriChain").AssignMaterialsByNames() },
                    { (typeof(bool), "HideOriginal"), true }
                }));

                AddGameDataObjectAutomatically(DynamicGDOBuilder.CreateDynamicGDO(type, "CrabCrane", new Dictionary<(Type, string), object>
                {
                    { (craneCosmeticTypeEnum, "CosmeticType"), 3 },
                    { (typeof(GameObject), "Prefab"), Bundle.LoadAsset<GameObject>("CrabCrane").AssignMaterialsByNames() },
                    { (typeof(bool), "HideOriginal"), true }
                }));

                return;
            }
        }
    }
}