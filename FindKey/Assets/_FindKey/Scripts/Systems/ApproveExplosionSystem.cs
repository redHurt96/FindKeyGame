using AP.FindKey.Common;
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

        private void TryApproveExplosion(Vector3 point)
        {
            if (GameData.Instance.ExplosionTryCount < Settings.Instance.ExplosionTryCount)
                GlobalEvents.ExplosionApproved?.Invoke(point);
        }
    }
}