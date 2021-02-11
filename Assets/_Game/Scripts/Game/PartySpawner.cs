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

    public void SpawnNewParty(List<PartyMemberData> _partyData)
    {
        Party.Clear();
        // spawn each party member we have, as long as we're below max
        for (int i = 0; i < _partyData.Count && i < _spawnLocations.Count; i++)
        {
            // if we have a valid party member and a valid location, spawn
            if (_partyData[i] != null && _spawnLocations[i] != null)
            {
                SpawnMember(i, _partyData[i], _parentGameObject);
            }
        }
    }

    public void SpawnMember(int slotIndex, PartyMemberData data,  Transform parentGameObject)
    {
        slotIndex = Mathf.Clamp(slotIndex, 0, _spawnLocations.Count);
        // guard clause
        if (_spawnLocations[slotIndex] == null)
            return;

        Debug.Log("Spawn: " + data.Name);
        PartyMember newPartyMember = Instantiate(_partyMemberPrefab, _spawnLocations[slotIndex].position, Quaternion.identity);
        // load in party member data
        newPartyMember.Initialize(data);
        // organize it in hierarchy
        newPartyMember.gameObject.name = "PartyMember_" + data.Name;
        newPartyMember.transform.SetParent(parentGameObject.transform);

        Party.Add(newPartyMember);
    }
}
