using UnityEngine;

namespace AP.FindKey.MonoBehaviours
{
    public class AdditionalExplosionPoint : MonoBehaviour, IExploded
    {
        [SerializeField] private ExplosionRigidbody[] _rigidbodies;
        [SerializeField] private Transform _point;

        public void Explode(Vector3 from)
        {
            foreach (ExplosionRigidbody rigidbody in _rigidbodies)
                rigidbody.Explode(_point.position);
        }

        [ContextMenu(nameof(AssignChildrenRigidbodies))]
        private void AssignChildrenRigidbodies()
        {
            _rigidbodies = GetComponentsInChildren<ExplosionRigidbody>();
        }
    }
}