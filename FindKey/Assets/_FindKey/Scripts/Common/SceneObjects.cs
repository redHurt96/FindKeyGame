using RH.Utilities.SingletonAccess;
using UnityEngine;

namespace AP.FindKey.Common
{
    public class SceneObjects : MonoBehaviourSingleton<SceneObjects>
    {
        public GameObject FinishUi;
        public GameObject FailUi;
    }
}