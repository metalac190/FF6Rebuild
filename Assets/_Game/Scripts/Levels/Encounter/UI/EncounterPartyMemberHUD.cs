using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EncounterPartyMemberHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _nameView;
    [SerializeField] TextMeshProUGUI _hpView;
    [SerializeField] CTGauge _ctGauge;

    PartyMember _partyMember;
    
    string _name = "...";
    int _hp = 0;

    public void Initialize(PartyMember partyMember)
    {
        _partyMember = partyMember;

        _nameView.text = partyMember.Name;
        _hpView.text = partyMember.HP.ToString();
        //CT Gauge
        _ctGauge.SetScale(partyMember.CT, partyMember.MaxCT);
    }
}
