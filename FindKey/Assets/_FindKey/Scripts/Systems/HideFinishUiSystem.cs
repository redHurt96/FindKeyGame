using AP.FindKey.Common;
using RH.Utilities.ComponentSystem;

namespace AP.FindKey.Systems
{
    public class HideFinishUiSystem : BaseSystem
    {
        protected override void Init() => 
            GlobalEvents.GoToNextLevel.AddListener(HideUi);

        public override void Dispose() => 
            GlobalEvents.KeyFounded.RemoveListener(HideUi);

        private void HideUi() => 
            SceneObjects.Instance.FinishUi.SetActive(false);
    }
}