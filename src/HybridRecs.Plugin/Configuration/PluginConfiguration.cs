using MediaBrowser.Model.Plugins;
using System.Collections.Generic;

namespace HybridRecs.Plugin
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public bool EnableAdvancedSuggestions { get; set; } = true;
        public bool EnableTrendingFeeds { get; set; } = true;
        public bool EnableSeasonalMode { get; set; } = true;

        // Weights
        public double NewReleaseWeight { get; set; } = 0.6;
        public double ContinueWatchingWeight { get; set; } = 0.8;
        public double FriendActivityWeight { get; set; } = 0.5;
        public double SimilarTasteWeight { get; set; } = 0.7;

        // Seasonal
        public List<string> SeasonalTags { get; set; } = new() { "Halloween", "Holiday", "Summer", "Awards" };
        public int SeasonalWindowDays { get; set; } = 45;

        // ML
        public bool EnableLocalEmbeddings { get; set; } = false;
    }
}