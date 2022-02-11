using AP.FindKey.Common;
using RH.Utilities.ComponentSystem;

namespace AP.FindKey.Systems
{
    public class ShowFinishUiSystem : BaseSystem
    {
        protected override void Init() => 
            GlobalEvents.KeyFounded.AddListener(ShowFinishUi);

        public override void Dispose() => 
            GlobalEvents.KeyFounded.RemoveListener(ShowFinishUi);

        private void ShowFinishUi() => 
            SceneObjects.Instance.FinishUi.SetActive(true);
    }
}