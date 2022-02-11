using AP.FindKey.Common;
using AP.FindKey.MonoBehaviours;
using RH.Utilities.ComponentSystem;
using UnityEngine;

namespace AP.FindKey.Systems
{
    public class ApproveExplosionSystem : BaseSystem
    {
        protected override void Init() => 
            GlobalEvents.ExplosionIntent.AddListener(TryApproveExplosion);

        public override void Dispose() => 
            GlobalEvents.ExplosionIntent.RemoveListener(TryApproveExplosion);

        private void TryApproveExplosion(GameObject at)
        {
            if (at.GetComponent<Key>() != null)
                GlobalEvents.KeyFounded?.Invoke();
            else if (GameData.Instance.ExplosionTryCount < Settings.Instance.ExplosionTryCount)
                GlobalEvents.ExplosionApproved?.Invoke(at.transform.position);
            else
                GlobalEvents.LevelFailed?.Invoke();
        }
    }
}