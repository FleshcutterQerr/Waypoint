using System.ComponentModel;

namespace Waypoint.Enums
{
    public enum APIEndpoints
    {
        [Description("https://api.guildwars2.com/v2/items")]
        ITEMS,
        [Description("https://api.guildwars2.com/v2/recipes")]
        RECIPES,
        [Description("https://api.guildwars2.com/v2/skins")]
        SKINS,
        [Description("https://api.guildwars2.com/v2/continents")]
        CONTINENTS,
        [Description("https://api.guildwars2.com/v2/maps")]
        MAPS,
        [Description("https://api.guildwars2.com/v2/build")]
        BUILD,
        [Description("https://api.guildwars2.com/v2/colors")]
        COLORS,
        [Description("https://api.guildwars2.com/v2/files")]
        FILES,
        [Description("https://api.guildwars2.com/v2/quaggans")]
        QUAGGANS,
        [Description("https://api.guildwars2.com/v2/worlds")]
        WORLDS
    }
}
