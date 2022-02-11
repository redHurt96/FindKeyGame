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
            IncreaseTargetFrameRate();
            InitSettings();
            CreateGameData();
            CreateSystems();
        }

        private static void IncreaseTargetFrameRate() => 
            Application.targetFrameRate = 60;

        private void InitSettings()
        {
            _settings.CreateInstance();
            _levelPool.CreateInstance();
        }

        private static void CreateGameData() => 
            new GameData();

        private static void CreateSystems()
        {
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