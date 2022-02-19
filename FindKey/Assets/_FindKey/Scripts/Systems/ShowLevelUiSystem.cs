using AP.FindKey.Common;
using RH.Utilities.ComponentSystem;

namespace AP.FindKey.Systems
{
    public class ShowLevelUiSystem : BaseSystem
    {
        protected override void Init()
        {
            GlobalEvents.RestartLevel.AddListener(Show);
            GlobalEvents.GoToNextLevel.AddListener(Show);
        }

        public override void Dispose()
        {
            GlobalEvents.RestartLevel.RemoveListener(Show);
            GlobalEvents.GoToNextLevel.RemoveListener(Show);
        }

        private void Show() => 
            SceneObjects.Instance.LevelUi.SetActive(true);
    }
}