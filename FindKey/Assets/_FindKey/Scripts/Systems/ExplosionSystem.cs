using AP.FindKey.Common;
using AP.FindKey.MonoBehaviours;
using RH.Utilities.ComponentSystem;
using UnityEngine;

namespace AP.FindKey.Systems
{
    public class ExplosionSystem : BaseSystem
    {
        private Collider[] _colliders = new Collider[50];
        private int _layerMask;

        protected override void Init()
        {
            _layerMask = 1 << LayerMask.NameToLayer("Default");
            GlobalEvents.ExplosionApproved.AddListener(Explode);
        }

        public override void Dispose() =>
            GlobalEvents.ExplosionApproved.RemoveListener(Explode);

        private void Explode(Vector3 at)
        {
            var collidersCount = FindColliders(at);
            ApplyExplosionForce(at, collidersCount);
            UpdateTryCount();
        }

        private int FindColliders(Vector3 at)
        {
            int collidersCount =
                Physics.OverlapSphereNonAlloc(at, Settings.Instance.ExplosionRadius, _colliders, _layerMask);

            return collidersCount;
        }

        private void ApplyExplosionForce(Vector3 at, int collidersCount)
        {
            for (int i = 0; i < collidersCount; i++)
            {
                if (_colliders[i].TryGetComponent(out IExploded iExploded))
                    iExploded.Explode(at);
            }
        }

        private static void UpdateTryCount() => GameData.Instance.ExplosionTryCount++;
    }
}