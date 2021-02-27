using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RPG.Encounter
{
    public class HeroEntry : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _nameView;
        [SerializeField] TextMeshProUGUI _hpView;
        [SerializeField] CTGauge _ctGauge;

        ActionTimer _actionTimer;
        Hero _hero;   // hold the reference for when data updates

        private void OnDestroy()
        {
            UnSubscribeEvents();
        }

        public void Initialize(Hero hero)
        {
            //Debug.Log("Init");
            _hero = hero;
            _actionTimer = hero.ActionTimer;

            _nameView.text = hero.Name;
            _hpView.text = hero.Health.CurrentHealth.ToString();

            _ctGauge.SetScale(_actionTimer.CT, _actionTimer.MaxCT);

            //Debug.Log("Sub");
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            if (_hero != null)
            {
                _actionTimer.CTChanged += OnCTChanged;
            }  
        }

        void UnSubscribeEvents()
        {
            if (_hero != null)
            {
                _actionTimer.CTChanged -= OnCTChanged;
            }  
        }

        void OnCTChanged(float value)
        {
            _ctGauge.SetScale(_actionTimer.CT, _actionTimer.MaxCT);
        }
    }
}

