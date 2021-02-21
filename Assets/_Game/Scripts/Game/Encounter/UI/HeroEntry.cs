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

        Hero _hero;   // hold the reference for when data updates

        private void OnEnable()
        {
            //Debug.Log("Sub");
            SubscribeEvents();
        }

        private void OnDisable()
        {
            //Debug.Log("UnSub");
            UnSubscribeEvents();
        }

        public void Initialize(Hero hero)
        {
            //Debug.Log("Init");
            _hero = hero;

            _nameView.text = hero.Name;
            _hpView.text = hero.HP.ToString();
            _ctGauge.SetScale(hero.CT, hero.MaxCT);
        }

        private void SubscribeEvents()
        {
            if (_hero != null)
            {
                _hero.CTChanged += OnCTChanged;
            }  
        }

        void UnSubscribeEvents()
        {
            if (_hero != null)
            {
                _hero.CTChanged -= OnCTChanged;
            }  
        }

        void OnCTChanged(float value)
        {
            _ctGauge.SetScale(_hero.CT, _hero.MaxCT);
        }
    }
}

