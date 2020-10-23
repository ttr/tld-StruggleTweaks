using ModSettings;
using System.Reflection;

namespace StruggleTweaks
{
	internal class StruggleTweaksSettings : JsonModSettings
	{

		[Name("Chance to kill wolf after struggle")]
		[Description("")]
		[Slider(0f, 100f)]
		public float chanceToKillWolfAfterStruggle = 80f;

		[Name("Wolf bleed time")]
		[Description("In minutes")]
		[Slider(0f, 100f)]
		public float wolfBleedoutMinutes = 10f;

		[Name("Struggle tap mutiplier")]
		[Description("")]
		[Slider(0.1f, 10f)]
		public float tapIncrement = 1f;
	}
	internal static class Settings
	{
		public static StruggleTweaksSettings options;
		public static void OnLoad()
		{
			options = new StruggleTweaksSettings();
			options.AddToModSettings("Strugle Tweaks Settings");
		}
	}
}