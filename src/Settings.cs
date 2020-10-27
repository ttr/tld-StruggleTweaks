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

		[Name("Struggle tap value")]
		[Description("Value of tap - not mutiplier (as was before) - higher means quicker to win struggle. Default:6")]
		[Slider(0.1f, 30f)]
		public float tapIncrement = 6f;
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