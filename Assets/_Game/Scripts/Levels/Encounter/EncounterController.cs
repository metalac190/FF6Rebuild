using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterController : MonoBehaviour
{
    [SerializeField] InputController _input = null;
    public InputController Input => _input;

    [SerializeField] PartySpawner _partySpawner = null;
    public PartySpawner PartySpawner => _partySpawner;

    [SerializeField] AreaEncounterData _encounterData;
    public AreaEncounterData EncounterData => _encounterData;

    [SerializeField] List<PartyMemberData> _partyMembersToLoad = new List<PartyMemberData>();
    public List<PartyMemberData> PartyDataToLoad => _partyMembersToLoad;

    //public List<UnitBase> PartyMembers;
    //public List<UnitBase> Enemies;
}
