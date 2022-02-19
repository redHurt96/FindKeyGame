using AP.FindKey.Common;
using RH.Utilities.ComponentSystem;

namespace AP.FindKey.Systems
{
    public class HideLevelUiSystem : BaseSystem
    {
        protected override void Init()
        {
            GlobalEvents.LevelFailed.AddListener(Hide);
            GlobalEvents.KeyFounded.AddListener(Hide);
        }

        public override void Dispose()
        {
            GlobalEvents.LevelFailed.AddListener(Hide);
            GlobalEvents.KeyFounded.AddListener(Hide);
        }

        private void Hide() => 
            SceneObjects.Instance.LevelUi.SetActive(false);
    }
}