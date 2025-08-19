using MediaBrowser.Common;
using MediaBrowser.Controller.Library;
using MediaBrowser.Model.Tasks;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HybridRecs.Plugin.Tasks
{
    public class RefreshRecommendationsTask : IScheduledTask
    {
        private readonly ILogger<RefreshRecommendationsTask> _logger;

        public RefreshRecommendationsTask(ILogger<RefreshRecommendationsTask> logger)
        {
            _logger = logger;
        }

        public string Name => "HybridRecs: Refresh Recommendation Index";
        public string Key => "HybridRecsRefresh";
        public string Description => "Rebuilds hybrid suggestion/trending indices.";
        public string Category => "HybridRecs";

        public IEnumerable<TaskTriggerInfo> GetDefaultTriggers()
        {
            // Run hourly by default
            yield return new TaskTriggerInfo { Type = TaskTriggerInfo.TriggerInterval, IntervalTicks = TimeSpan.FromHours(1).Ticks };
        }

        public async Task ExecuteAsync(IProgress<double> progress, CancellationToken cancellationToken)
        {
            _logger.LogInformation("HybridRecs: starting refresh...");
            progress.Report(0.1);
            // TODO: build indices (rule-based + optional embeddings)
            await Task.Delay(500, cancellationToken);
            progress.Report(1.0);
            _logger.LogInformation("HybridRecs: refresh done.");
        }
    }
}