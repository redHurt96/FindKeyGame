using AP.FindKey.Common;
using RH.Utilities.UI;

namespace AP.FindKey.UI
{
    public class RestartLevelButton : BaseActionButton
    {
        protected override void PerformOnClick()
        {
            GameData.Instance.ExplosionTryCount = 0;
            GlobalEvents.RestartLevel?.Invoke();
        }
    }
}