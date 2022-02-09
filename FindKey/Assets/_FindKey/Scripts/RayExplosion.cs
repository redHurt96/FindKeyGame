using UnityEngine;

public class RayExplosion : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _radius;

    private readonly float _upwardsModifier = 1f;
    private readonly ForceMode _forceMode = ForceMode.Force;

    private Camera _camera;
    private int _layerMask;

    private Collider[] _colliders = new Collider[30];

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

        if (Physics.Raycast(ray, out var hit, 20f, _layerMask))
        {
            Debug.Log(hit.collider.gameObject.name);
            ExplodeAt(hit);
        }
    }

    private void ExplodeAt(RaycastHit hit)
    {
        int collidersCount = Physics.OverlapSphereNonAlloc(hit.point, _radius, _colliders, _layerMask);

        for (int i = 0; i < collidersCount; i++)
            _colliders[i].attachedRigidbody.AddExplosionForce(_force, hit.point, _radius, _upwardsModifier, _forceMode);
    }
}
