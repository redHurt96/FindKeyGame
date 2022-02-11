using AP.FindKey.Common;
using RH.Utilities.ComponentSystem;

namespace AP.FindKey.Systems
{
    public class ShowFailUiSystem : BaseSystem
    {
        protected override void Init() => 
            GlobalEvents.LevelFailed.AddListener(ShowFailUi);

        public override void Dispose() => 
            GlobalEvents.LevelFailed.RemoveListener(ShowFailUi);

        private void ShowFailUi() => 
            SceneObjects.Instance.FailUi.SetActive(true);
    }
}