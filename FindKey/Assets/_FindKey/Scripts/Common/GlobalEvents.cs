using UnityEngine;
using UnityEngine.Events;

namespace AP.FindKey.Common
{
    public static class GlobalEvents
    {
        public static UnityEvent<GameObject> ExplosionIntent = new UnityEvent<GameObject>();
        public static UnityEvent<Vector3> ExplosionApproved = new UnityEvent<Vector3>();
        public static UnityEvent KeyFounded = new UnityEvent();
        public static UnityEvent GoToNextLevel = new UnityEvent();
        public static UnityEvent LevelFailed = new UnityEvent();
        public static UnityEvent RestartLevel = new UnityEvent();
    }
}