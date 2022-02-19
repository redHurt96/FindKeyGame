using AP.FindKey.Common;
using RH.Utilities.SingletonAccess;
using UnityEngine;

namespace RoofRace.Infrastructure
{
    [CreateAssetMenu(fileName = "LevelPool", menuName = "Game/LevelPool")]
    public class LevelPool : SingletonScriptableObject<LevelPool>
    {
        [SerializeField] private GameObject[] _levelsPrefabs;

        private int _current = 0;

        public GameObject Current => _levelsPrefabs[_current];

        public void ClearIndex() => 
            _current = 0;
        
        public void IncreaseIndex()
        {
            _current++;
            _current %= _levelsPrefabs.Length;

            GameData.Instance.LevelNumber++;
        }
    }
}