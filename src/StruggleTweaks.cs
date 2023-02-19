using MelonLoader;
using HarmonyLib;
using Il2Cpp;

namespace StruggleTweaks {
    public static class BuildInfo
    {
        internal const string ModName = "StruggleTweaks";
        internal const string ModAuthor = "AlexTheRegent, ttr";
        internal const string ModVersion = "2.4.0";

    }
    internal class StruggleTweaks : MelonMod
    {

        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
            LoggerInstance.Msg($"[{BuildInfo.ModName}] Version {BuildInfo.ModVersion} loaded!");
        }


        [HarmonyPatch(typeof(PlayerStruggle), "WolfTap")]
        public class StruggleTweaksTap
        {
            private static void Postfix(PlayerStruggle __instance)
            {
                if (Settings.options.wolfBleedoutMinutes >= 0f)
                {

                    __instance.m_WolfBleedoutMinutes = Settings.options.wolfBleedoutMinutes;
                }

                if (Settings.options.tapIncrement >= 0f)
                {
                    __instance.m_TapIncrement = Settings.options.tapIncrement;
                }
            }
        }

        [HarmonyPatch(typeof(PlayerStruggle), "MakePartnerFlee")]
        public class StruggleTweaksKillOnFlee
        {
            private static void Postfix(PlayerStruggle __instance)
            {
                if (__instance.m_PartnerBaseAi.m_AiWolf)
                {
                    if (Utils.RollChance(Settings.options.chanceToKillWolfAfterStruggle))
                    {
                        __instance.m_PartnerBaseAi.EnterDead();
                    }
                }
            }
        }
    }
}