using UnityEngine;
using UnityEngine.Events;

namespace AP.FindKey.Common
{
    public static class GlobalEvents
    {
        public static UnityEvent<Vector3> ExplosionIntent = new UnityEvent<Vector3>();
        public static UnityEvent<Vector3> ExplosionApproved = new UnityEvent<Vector3>();
    }
}