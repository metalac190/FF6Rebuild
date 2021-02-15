using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterPartyHUD : MonoBehaviour
{
    [SerializeField] EncounterPartyMemberHUD _partyMemberHUDPrefab;
    [SerializeField] Transform _partyMemberHUDParent;

    public void CreatePartyHUD(List<PartyMember> partyMembers)
    {
        // create a HUD for each member
        for (int i = 0; i < partyMembers.Count; i++)
        {
            EncounterPartyMemberHUD newMemberHUD
                = Instantiate(_partyMemberHUDPrefab, _partyMemberHUDParent);
            newMemberHUD.Initialize(partyMembers[i]);
            newMemberHUD.gameObject.name = "PartyMemberHUD_" + i.ToString();
        }
    }
}
