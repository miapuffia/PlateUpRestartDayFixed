using HarmonyLib;
using KitchenMods;
using System.Collections.Generic;
using System.Reflection;

// Namespace should have "Kitchen" in the beginning
namespace KitchenRestartDayFixed {
	public class Main : IModInitializer {
		public const string MOD_ID = "miapuffia.PlateUp.RestartDayFixed";
		public const string MOD_NAME = "Restart Day Fixed";
		public const string MOD_VERSION = "1.0.0";

		public void PostActivate(Mod mod) {
			Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MOD_ID);
		}

		public void PreInject() { }

		public void PostInject() { }
	}
}
