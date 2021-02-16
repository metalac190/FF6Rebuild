using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterLoader : MonoBehaviour
{
    [Header("Data Assets - Save/Load later on")]
    [SerializeField] AreaEncounterData _encounterData;
    [SerializeField] List<PartyMemberData> _partyMembersToLoad = new List<PartyMemberData>();

    public AreaEncounterData EncounterData => _encounterData;
    public List<PartyMemberData> PartyDataToLoad => _partyMembersToLoad;

    public EncounterGroup GetEnemyEncounter()
    {
        //TODO load encoutner from data instead of scene reference
        int randomIndex = Random.Range(0, _encounterData.EncounterGroups.Count);
        return EncounterData.EncounterGroups[randomIndex];
    }
}
