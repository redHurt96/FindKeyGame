using AP.FindKey.Common;
using RH.Utilities.ComponentSystem;

namespace AP.FindKey.Systems
{
    public class HideFailUiSystem : BaseSystem
    {
        protected override void Init() => 
            GlobalEvents.RestartLevel.AddListener(HideFailUi);

        public override void Dispose() => 
            GlobalEvents.RestartLevel.RemoveListener(HideFailUi);

        private void HideFailUi() => 
            SceneObjects.Instance.FailUi.SetActive(false);
    }
}