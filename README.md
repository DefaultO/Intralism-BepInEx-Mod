![Unbenannt-2](https://github.com/DefaultO/Intralism-BepInEx-Mod/assets/42414542/8dd7f627-6072-4c9a-ab67-ec9a4a63986e)
# Intralism BepInEx Mod
This is my take on a Plugin for the game Intralism. As wished for by Ludeo in a Discord reply regarding [their own Intralism Plugin](https://github.com/Ludeo/IntralismPlugins).
> ...
> Maybe we can get some people together to start making plugins
> ...

I stripped my Cheats and Exploits from this Plugin so that normal players can use it without risking any punishments.

### How to use:
1. Download BepInEx_x64 v5.4.21 from [here](https://github.com/BepInEx/BepInEx/releases/tag/v5.4.21). It can work with newer versions of it. But since I have been developing this Plugin using that specific version. I can't and won't guarantee that the Plugin works with newer versions of it.
2. Extract the files into the root folder of the Intralism game (next to Intralism.exe). Start the game so that BepInEx can initialize itself. After successfully loading into the game - BepInEx should be installed successfully. Close the game again.
3. Build the project. In order to build it, you will have to provide it with all dependencies it needs. You can find all of these .dlls in the Intralism game directory ``..\Intralism\Intralism_Data\Managed``.
4. Drop the ``Intralism-Internal.dll`` into the plugins folder ``..\Intralism\BepInEx\plugins``. If it doesn't exist, create it and proceed.
5. Start the game.

### How does this work?
The game doesn't give you untradable Steam Items for the default items. Instead, it calls a function that gives you the red arc and the default home screen music theme. This Plugins abuses this fact and "overwrites" the function with our own one which loops through all existing items and adds them to your inventory. Pretty simple, but effective.

```csharp
public static bool AddAllItemsToInventory(ItemsHandler __instance)
{
    for (int  i = 0; i < __instance.itemsData.Count; i++)
    {
        __instance.userItems.Add(new SteamInventoryItem((ulong)i, __instance.itemsData[i], true));
    }

    return false; // don't run original method
}
```

### Can you add more features?
No. I am not interested in this game anymore. I have found this laying around on my hard disk and decided to upload it to GitHub. Or else my GitHub profile looks like I have been doing absolutely nothing all these years. With most projects being private or only shared amongst friends because they are too valueable to me to share them yet.
