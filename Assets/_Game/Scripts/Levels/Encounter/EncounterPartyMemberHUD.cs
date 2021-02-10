using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EncounterPartyMemberHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _nameView;
    [SerializeField] TextMeshProUGUI _hpView;
    
    string _name = "...";
    int _hp = 0;

    public void Display(PartyMember partyMember)
    {
        //_name = data.
        //_nameView.text = partyMember
    }
}
