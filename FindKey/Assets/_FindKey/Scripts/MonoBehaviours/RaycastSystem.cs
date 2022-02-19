using AP.FindKey.Common;
using UnityEngine;

namespace AP.FindKey.MonoBehaviours
{
    public class RaycastSystem : MonoBehaviour
    {
        private Camera _camera;
        private int _layerMask;

        private void Start()
        {
            _camera = Camera.main;
            _layerMask = 1 << LayerMask.NameToLayer("Default");
        }

        private void Update()
        {
            if (!Input.GetMouseButtonDown(0)) 
                return;

            Explode();
        }

        private void Explode()
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, 50f, _layerMask))
                GlobalEvents.ExplosionIntent?.Invoke(hit.collider.gameObject);
        }
    }
}