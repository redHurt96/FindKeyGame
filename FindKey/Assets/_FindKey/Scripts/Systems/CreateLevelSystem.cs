using AP.FindKey.Common;
using RH.Utilities.ComponentSystem;
using RoofRace.Infrastructure;
using UnityEngine;

namespace AP.FindKey.Systems
{
    public class CreateLevelSystem : BaseSystem
    {
        protected override void Init()
        {
            GlobalEvents.GoToNextLevel.AddListener(LoadNextScene);
            GlobalEvents.RestartLevel.AddListener(LoadCurrentScene);
            LoadCurrentScene();
        }

        public override void Dispose()
        {
            GlobalEvents.GoToNextLevel.RemoveListener(LoadNextScene);
            GlobalEvents.RestartLevel.RemoveListener(LoadCurrentScene);
        }

        private void LoadNextScene()
        {
            LevelPool.Instance.IncreaseIndex();
            LoadCurrentScene();
        }

        private void LoadCurrentScene()
        {
            if (GameData.Instance.CurrentLevel != null)
                Object.Destroy(GameData.Instance.CurrentLevel);

            GameData.Instance.CurrentLevel = Object.Instantiate(LevelPool.Instance.Current);
        }
    }
}