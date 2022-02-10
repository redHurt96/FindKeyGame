using RH.Utilities.SingletonAccess;

namespace AP.FindKey.Common
{
    public class GameData : Singleton<GameData>
    {
        public int ExplosionTryCount = 0;
    }
}