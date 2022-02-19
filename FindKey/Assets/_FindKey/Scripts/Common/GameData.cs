using RH.Utilities.SingletonAccess;
using UnityEngine;

namespace AP.FindKey.Common
{
    public class GameData : Singleton<GameData>
    {
        public int ExplosionTryCount
        {
            get => _explosionTryCount;
            set
            {
                int oldValue = _explosionTryCount;
                _explosionTryCount = value;
                
                if (value != oldValue)
                    GlobalEvents.TryCountChanged.Invoke();
            }
        }

        public GameObject CurrentLevel;
        public int LevelNumber { get; set; }

        private int _explosionTryCount = 0;
    }
}