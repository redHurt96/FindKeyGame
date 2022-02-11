using AP.FindKey.Common;
using UnityEngine;

namespace AP.FindKey.MonoBehaviours
{
    [RequireComponent(typeof(Rigidbody))]
    public class ExplosionRigidbody : MonoBehaviour, IExploded
    {
        [SerializeField] private Rigidbody _rigidbody;

        public void Explode(Vector3 from)
        {
            _rigidbody.AddExplosionForce(Settings.Instance.ExplosionForce, from,
                Settings.Instance.ExplosionRadius, 1, ForceMode.Force);
        }

        [ContextMenu(nameof(AssignRigidbody))]
        private void AssignRigidbody() => _rigidbody = GetComponent<Rigidbody>();
    }
}