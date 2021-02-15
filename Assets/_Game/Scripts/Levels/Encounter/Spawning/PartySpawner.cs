using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartySpawner : MonoBehaviour
{
    [SerializeField] PartyMember _partyMemberPrefab;
    [SerializeField] Transform _parentGameObject;
    [SerializeField] List<Transform> _spawnLocations;

    public List<PartyMember> Party { get; private set; } = new List<PartyMember>();

    private void Awake()
    {
        // validate
        if (_parentGameObject == null)
            _parentGameObject = gameObject.transform;
    }

    public void SpawnNewParty(List<PartyMemberData> partyData)
    {
        Party.Clear();
        // spawn each party member we have, as long as we're below max
        for (int i = 0; i < partyData.Count && i < _spawnLocations.Count; i++)
        {
            if (partyData[i] != null && _spawnLocations[i] != null)
            {
                PartyMember newMember = SpawnMember(i, partyData[i], _parentGameObject);
                Party.Add(newMember);
            }
        }
    }

    public PartyMember SpawnMember(int slotIndex, PartyMemberData data,  Transform parentGameObject)
    {
        PartyMember newPartyMember = Instantiate(_partyMemberPrefab, _spawnLocations[slotIndex].position, Quaternion.identity);
        // load in party member data
        newPartyMember.Initialize(data);
        // organize it in hierarchy
        newPartyMember.gameObject.name = "PartyMember_" + data.Name;
        newPartyMember.transform.SetParent(parentGameObject.transform);

        return newPartyMember;
        
    }
}
