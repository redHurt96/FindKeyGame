using AP.FindKey.Common;
using GameAnalyticsSDK;
using RH.Utilities.ComponentSystem;

namespace AP.FindKey.Analytics
{
    public class LevelFinishAnalyticsSender : BaseSystem
    {
        protected override void Init() => 
            GlobalEvents.KeyFounded.AddListener(LogLevelFinish);

        public override void Dispose() => 
            GlobalEvents.KeyFounded.RemoveListener(LogLevelFinish);

        private void LogLevelFinish() => 
            GameAnalytics.NewDesignEvent("Level win", AnalyticsLevelDataCreator.Create());
    }
}