using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;

namespace HybridRecs.Plugin
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public Plugin() : base() { }

        public override string Name => "Hybrid Recommendations";
        public override Guid Id => Guid.Parse("12345678-abcd-ef00-9876-1234567890ab");

        public IEnumerable<PluginPageInfo> GetPages()
        {
            yield return new PluginPageInfo
            {
                Name = "hybridrecs",
                EmbeddedResourcePath = GetType().Namespace + ".web.admin.html"
            };
        }
    }
}
