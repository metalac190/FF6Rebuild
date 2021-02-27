using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter 
{
    public class EncounterLoader : MonoBehaviour
    {
        [Header("Data Assets - Save/Load later on")]
        [SerializeField] AreaEncounterData _encounterData;
        [SerializeField] List<HeroData> _partyMembersToLoad = new List<HeroData>();

        public AreaEncounterData EncounterData => _encounterData;
        public List<HeroData> PartyDataToLoad => _partyMembersToLoad;
    }
}
