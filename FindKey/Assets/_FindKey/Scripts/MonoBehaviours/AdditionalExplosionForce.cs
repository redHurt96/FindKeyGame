using UnityEngine;

namespace AP.FindKey.MonoBehaviours
{
    public class AdditionalExplosionForce : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Vector3 _direction;
        [SerializeField] private float _force = 100;

        public void Explode(Vector3 from) => 
            _rigidbody.AddForce(_direction * _force, ForceMode.Force);

        [ContextMenu(nameof(AssignRigidbody))]
        private void AssignRigidbody() =>
            _rigidbody = GetComponent<Rigidbody>();
        
        [ContextMenu(nameof(Explode))]
        private void Explode() => 
            Explode(Vector3.zero);
    }
}