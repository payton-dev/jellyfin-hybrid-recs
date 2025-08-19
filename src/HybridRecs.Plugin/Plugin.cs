using MediaBrowser.Common;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Model.Updates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace HybridRecs.Plugin
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public override string Name => "Hybrid Recommendations";
        public override Guid Id => new Guid("9c3f9f7b-8e1e-4a8e-8f2d-71b7a5a7d3c0");
        public override string Description => "Hybrid recommendations (advanced suggestions + trending feeds + seasonal).";

        public Plugin(IApplicationPaths appPaths, IXmlSerializer xml, IApplicationHost appHost)
            : base(appPaths, xml) { }

        public IEnumerable<PluginPageInfo> GetPages()
        {
            // Admin UI embedded page
            yield return new PluginPageInfo
            {
                Name = "hybridrecs",
                EmbeddedResourcePath = GetType().Namespace + ".web.admin.html"
            };
        }
    }
}