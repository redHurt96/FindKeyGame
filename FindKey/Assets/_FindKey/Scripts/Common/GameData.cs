using RH.Utilities.SingletonAccess;
using UnityEngine;

namespace AP.FindKey.Common
{
    public class GameData : Singleton<GameData>
    {
        public int ExplosionTryCount = 0;

        public GameObject CurrentLevel;
    }
}