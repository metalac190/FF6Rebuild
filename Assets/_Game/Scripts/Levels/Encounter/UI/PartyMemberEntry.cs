using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RPG.Levels.Encounter
{
    public class PartyMemberEntry : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _nameView;
        [SerializeField] TextMeshProUGUI _hpView;
        [SerializeField] CTGauge _ctGauge;

        PartyMember _partyMember;   // hold the reference for when data updates

        public void Display(PartyMember partyMember)
        {
            _partyMember = partyMember;

            _nameView.text = partyMember.Name;
            _hpView.text = partyMember.HP.ToString();
            //CT Gauge
            _ctGauge.SetScale(partyMember.CT, partyMember.MaxCT);
        }
    }
}

