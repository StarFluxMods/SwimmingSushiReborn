using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using Kitchen;
using SwimmingSushiReborn.Systems;
using SwimmingSushiReborn.Utilies;

namespace SwimmingSushiReborn.Patches
{
    [HarmonyPatch]
    public class ResolveStatusChangesPatch
    {
        [HarmonyTargetMethod]
        static MethodBase TargetMethod()
        {
            Type type = AccessTools.FirstInner(typeof(ResolveStatusChanges), t => t.Name.Contains($"c__DisplayClass_OnUpdate_LambdaJob0"));
            return AccessTools.FirstMethod(type, method => method.Name.Contains("OriginalLambdaBody"));
        }

        [HarmonyTranspiler]
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            CodeMatcher matcher = new(instructions);

            matcher.MatchForward(false, new CodeMatch(OpCodes.Brfalse), new CodeMatch(OpCodes.Ldloc_0),
                    new CodeMatch(OpCodes.Brfalse), new CodeMatch(OpCodes.Ldarg_0), new CodeMatch(OpCodes.Ldflda))
                .Advance(3)
                .Insert(new CodeInstruction(OpCodes.Stloc_0))
                .Insert(new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(ResolveStatusChangesPatch), "GetCustomProcessResults")))
                .Insert(new CodeInstruction(OpCodes.Ldloc_0))
                .Insert(new CodeInstruction(OpCodes.Ldobj, typeof(CItem)))
                .Insert(new CodeInstruction(OpCodes.Ldarg_3))
                .Insert(new CodeInstruction(OpCodes.Ldobj, typeof(CItemUndergoingProcess)))
                .Insert(new CodeInstruction(OpCodes.Ldarg_2));

            return matcher.InstructionEnumeration();
        }

        public static List<CustomProcessResult> customProcessSets = new List<CustomProcessResult>
        {
        };

        public static int GetCustomProcessResults(CItemUndergoingProcess cItemUndergoingProcess, CItem cItem, int defaultResult)
        {
            foreach (CustomProcessResult customProcessResult in customProcessSets)
            {
                if (customProcessResult.OriginalItemID == cItem.ID)
                {
                    if (customProcessResult.OriginalResultID == defaultResult)
                    {
                        if (SystemHelper.Instance.IsUserHoldingItem(customProcessResult.HeldItemID, cItemUndergoingProcess.Actor))
                        {
                            if (customProcessResult.NewResultID == GDOReferences.SalmonWithRoe.ID)
                            {
                                // Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_SPECIAL_KNIFE);
                            }

                            return customProcessResult.NewResultID;
                        }
                    }
                }
            }

            return defaultResult;
        }
    }

    public struct CustomProcessResult()
    {
        public int OriginalItemID;
        public int OriginalResultID;
        public int HeldItemID;
        public int NewResultID;
    }
}