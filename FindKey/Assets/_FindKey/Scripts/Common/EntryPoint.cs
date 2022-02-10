using AP.FindKey.Systems;
using UnityEngine;

namespace AP.FindKey.Common
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Settings _settings;

        private void Awake()
        {
            _settings.CreateInstance();

            new GameData();

            new ApproveExplosionSystem();
            new ExplosionSystem();
        }
    }
}