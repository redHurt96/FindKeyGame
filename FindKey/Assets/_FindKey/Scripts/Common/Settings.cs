using RH.Utilities.SingletonAccess;
using UnityEngine;

namespace AP.FindKey.Common
{
    [CreateAssetMenu(fileName = "Settings", menuName = "Game/Settings")]
    public class Settings : SingletonScriptableObject<Settings>
    {
        public float ExplosionForce = 300;
        public float ExplosionRadius = 3;
        public float ExplosionTryCount = 10;
    }
}