using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    public class PartyHUD : HUD
    {
        [Header("Party")]
        [SerializeField] HeroEntry _heroDisplayPrefab;
        [SerializeField] Transform _herDisplayParent;

        public void CreatePartyHUD(List<Hero> party)
        {
            // create a HUD for each member
            for (int i = 0; i < party.Count; i++)
            {
                HeroEntry newHeroDisplay
                    = Instantiate(_heroDisplayPrefab, _herDisplayParent);
                newHeroDisplay.Initialize(party[i]);
                newHeroDisplay.gameObject.name = "HeroDisplay_" + i.ToString();
            }
        }
    }
}

