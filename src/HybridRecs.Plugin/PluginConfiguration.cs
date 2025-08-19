using MediaBrowser.Model.Plugins;

namespace HybridRecs.Plugin
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public bool EnableSeasonalMode { get; set; } = false;
        public int ContinueWatchingPriority { get; set; } = 50;
        public int RecentlyAddedBoost { get; set; } = 50;
        public string TmdbApiKey { get; set; } = string.Empty;
        public string TraktApiKey { get; set; } = string.Empty;
        public bool EnableParentalControls { get; set; } = false;
        public bool EnableRewatchSuggestions { get; set; } = false;
        public bool EnableSkipShorts { get; set; } = false;
    }
}
