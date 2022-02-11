using AP.FindKey.Common;
using GameAnalyticsSDK;
using RH.Utilities.ComponentSystem;

namespace AP.FindKey.Analytics
{
    public class LevelFailAnalyticsSender : BaseSystem
    {
        protected override void Init() => 
            GlobalEvents.LevelFailed.AddListener(LogLevelFail);

        public override void Dispose() => 
            GlobalEvents.LevelFailed.RemoveListener(LogLevelFail);

        private void LogLevelFail() => 
            GameAnalytics.NewDesignEvent("Level fail", AnalyticsLevelDataCreator.Create());
    }
}