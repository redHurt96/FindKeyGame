using System.Collections.Generic;
using AP.FindKey.Common;

namespace AP.FindKey.Analytics
{
    public static class AnalyticsLevelDataCreator
    {
        public static Dictionary<string, object> Create()
        {
            return new Dictionary<string, object>
            {
                { "LevelNumber", GameData.Instance.LevelNumber },
                { "ExplosionsCount", GameData.Instance.ExplosionTryCount }
            };
        }
    }
}