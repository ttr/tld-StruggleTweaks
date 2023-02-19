using MelonLoader;
using System.Reflection;

//This is a C# comment. Comments have no impact on compilation.

[assembly: AssemblyTitle(StruggleTweaks.BuildInfo.ModName)]
[assembly: AssemblyCopyright($"Created by " + StruggleTweaks.BuildInfo.ModAuthor)]

[assembly: AssemblyVersion(StruggleTweaks.BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(StruggleTweaks.BuildInfo.ModVersion)]
[assembly: MelonInfo(typeof(StruggleTweaks.StruggleTweaks), StruggleTweaks.BuildInfo.ModName, StruggleTweaks.BuildInfo.ModVersion, StruggleTweaks.BuildInfo.ModAuthor)]

//This tells MelonLoader that the mod is only for The Long Dark.
[assembly: MelonGame("Hinterland", "TheLongDark")]