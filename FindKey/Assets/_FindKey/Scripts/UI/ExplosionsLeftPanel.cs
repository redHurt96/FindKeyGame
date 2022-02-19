using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using AP.FindKey.Common;
using UnityEngine;
using UnityEngine.UI;

namespace AP.FindKey.UI
{
    public class ExplosionsLeftPanel : MonoBehaviour
    {
        [SerializeField] private Text _count;

        private void Start()
        {
            GlobalEvents.TryCountChanged.AddListener(UpdateText);

            UpdateText();
        }

        private void OnDestroy() => 
            GlobalEvents.TryCountChanged.AddListener(UpdateText);

        private void UpdateText() =>
            _count.text = $"x{Settings.Instance.ExplosionTryCount - GameData.Instance.ExplosionTryCount}";
    }
}