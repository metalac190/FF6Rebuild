using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    public class PartyHUD : HUD
    {
        [Header("Party")]
        [SerializeField] PartyMemberEntry _partyMemberHUDPrefab;
        [SerializeField] Transform _partyMemberHUDParent;

        public void CreatePartyHUD(List<PartyMember> partyMembers)
        {
            // create a HUD for each member
            for (int i = 0; i < partyMembers.Count; i++)
            {
                PartyMemberEntry newMemberHUD
                    = Instantiate(_partyMemberHUDPrefab, _partyMemberHUDParent);
                newMemberHUD.Display(partyMembers[i]);
                newMemberHUD.gameObject.name = "PartyMemberHUD_" + i.ToString();
            }
        }
    }
}

