using AP.FindKey.Common;
using RH.Utilities.SingletonAccess;
using UnityEngine;

namespace RoofRace.Infrastructure
{
    [CreateAssetMenu(fileName = "LevelPool", menuName = "Game/LevelPool")]
    public class LevelPool : SingletonScriptableObject<LevelPool>
    {
        [SerializeField] private GameObject[] _levelsPrefabs;

        private int _current;

        public GameObject Current => _levelsPrefabs[_current];

        public void IncreaseIndex()
        {
            _current++;
            _current %= _levelsPrefabs.Length;

            GameData.Instance.LevelNumber++;
        }
    }
}