using System.Reflection;
using HarmonyLib;
using KitchenLib.Achievements;
using KitchenLib.Utils;
using SwimmingSushiReborn.Systems;

namespace SwimmingSushiReborn.Patches
{
    [HarmonyPatch(typeof(AchievementsManager), "CompleteAchievement")]
    public class AchievementsManagerPatch
    {
        private static FieldInfo modId = ReflectionUtils.GetField<AchievementsManager>("modId");
        static void Postfix(AchievementsManager __instance, bool __result, string key)
        {
            if (!__result) return;
            if ((string)modId.GetValue(__instance) != Mod.MOD_GUID) return;
            if (key != Mod.ACHIEVEMENT_SERVE_SALMONROLL) return;
            if (UnlockableCosmetics.instance == null) return;
            
            UnlockableCosmetics.instance.SetupCosmetics();
        }
    }
}