using AP.FindKey.Common;
using UnityEngine;

namespace AP.FindKey.MonoBehaviours
{
    public class CollectKeyFx : MonoBehaviour
    {
        [SerializeField] private GameObject _fxPrefab;

        private void Start() =>
            GlobalEvents.KeyFounded.AddListener(CreateFx);

        private void OnDestroy() =>
            GlobalEvents.KeyFounded.RemoveListener(CreateFx);

        private void CreateFx() =>
            Instantiate(_fxPrefab, transform);
    }
}