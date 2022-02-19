using AP.FindKey.Common;
using UnityEngine;

namespace AP.FindKey.MonoBehaviours
{
    [RequireComponent(typeof(Rigidbody))]
    public class ExplosionRigidbody : MonoBehaviour, IExploded
    {
        [SerializeField] private AdditionalExplosionForce _additionalExplosionForce;

        private Rigidbody _rigidbody;

        public void Explode(Vector3 from)
        {
            AssignRigidbody();
            AddForce(@from);
            TryApplyAdditionalForce(@from);
        }

        private void AssignRigidbody()
        {
            if (_rigidbody == null)
                _rigidbody = GetComponent<Rigidbody>();
        }

        private void AddForce(Vector3 @from)
        {
            _rigidbody.AddExplosionForce(Settings.Instance.ExplosionForce, @from,
                Settings.Instance.ExplosionRadius, 1, ForceMode.Force);
        }

        private void TryApplyAdditionalForce(Vector3 @from) => 
            _additionalExplosionForce?.Explode(@from);
    }
}