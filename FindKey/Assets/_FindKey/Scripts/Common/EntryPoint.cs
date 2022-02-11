using AP.FindKey.Systems;
using RoofRace.Infrastructure;
using UnityEngine;

namespace AP.FindKey.Common
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Settings _settings;
        [SerializeField] private LevelPool _levelPool;

        private void Start()
        {
            _settings.CreateInstance();
            _levelPool.CreateInstance();

            new GameData();

            new CreateLevelSystem();
            new ApproveExplosionSystem();
            new ExplosionSystem();
            new ShowFinishUiSystem();
            new HideFinishUiSystem();
            new ShowFailUiSystem();
            new HideFailUiSystem();
        }
    }
}