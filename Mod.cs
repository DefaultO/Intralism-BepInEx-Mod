using HarmonyLib;
using BepInEx;
using System.Reflection;

namespace Intralism_Internal
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class Mod : BaseUnityPlugin
    {
        public const string pluginGuid = "defaulto.intralism";
        public const string pluginName = "Intralism Mod";
        public const string pluginVersion = "1.0.0";

        public readonly Harmony harmony = new Harmony(pluginGuid);

        public void Awake()
        {
            MethodInfo addDefaultItemsToInventory = AccessTools.Method(typeof(ItemsHandler), "AJDGHDGDLOH");
            MethodInfo addAllItemsToInventory = AccessTools.Method(typeof(Mod), "AddAllItemsToInventory");

            harmony.Patch(addDefaultItemsToInventory, new HarmonyMethod(addAllItemsToInventory));
        }

        public static bool AddAllItemsToInventory(ItemsHandler __instance)
        {
            for (int  i = 0; i < __instance.itemsData.Count; i++)
            {
                __instance.userItems.Add(new SteamInventoryItem((ulong)i, __instance.itemsData[i], true));
            }

            return false; // don't run original method
        }
    }
}
