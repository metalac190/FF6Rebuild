using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartySpawner : MonoBehaviour
{
    [SerializeField] PartyMember _partyMemberPrefab;

    [SerializeField] List<Transform> _spawnLocations;

    public void SpawnParty(List<PartyMemberData> _partyMembers)
    {
        // spawn each party member we have, as long as we're below max
        for (int i = 0; i < _partyMembers.Count && i < _spawnLocations.Count; i++)
        {
            // if we have a valid party member and a valid location, spawn
            if (_partyMembers[i] != null && _spawnLocations[i] != null)
            {
                SpawnMember(i, _partyMembers[i], _spawnLocations[i].position);
            }
        }
    }

    public void SpawnMember(int slotIndex, PartyMemberData data, Vector3 position)
    {
        Debug.Log("Spawn: " + data.name);
        PartyMember newPartyMember = Instantiate(_partyMemberPrefab, position, Quaternion.identity);
        newPartyMember.transform.SetParent(this.transform);
        // load in party member data
        newPartyMember.Initialize(data);
        newPartyMember.gameObject.name = "PartyMember_" + data.Name;
    }
}
