using MelonLoader;
using Harmony;
using UnityEngine;

namespace StruggleTweaks {
    internal class StruggleTweaks : MelonMod
    {

        public override void OnApplicationStart()
        {
            Debug.Log($"[{InfoAttribute.Name}] Version {InfoAttribute.Version} loaded!");
            Settings.OnLoad();
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