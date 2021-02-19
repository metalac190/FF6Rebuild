using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Levels.Encounter
{
    public class PartyHUD : MonoBehaviour
    {
        [SerializeField] RectTransform _partyPanel;
        [SerializeField] PartyMemberEntry _partyMemberHUDPrefab;
        [SerializeField] Transform _partyMemberHUDParent;

        private void Awake()
        {
            // ensure disabled is the default state
            _partyPanel.gameObject.SetActive(false);
        }

        public void Show()
        {
            //TODO add panel animations later
            _partyPanel.gameObject.SetActive(true);
        }

        public void Hide()
        {
            //TODO add panel animations later
            _partyPanel.gameObject.SetActive(false);
        }

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

