using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    public class PartySpawner : MonoBehaviour
    {
        [SerializeField] Hero _partyMemberPrefab;
        [SerializeField] Transform _parentGameObject;
        [SerializeField] List<Transform> _spawnLocations;

        private void Awake()
        {
            // validate
            if (_parentGameObject == null)
                _parentGameObject = gameObject.transform;
        }

        public List<Hero> SpawnNewParty(List<HeroData> partyData)
        {
            List<Hero> newParty = new List<Hero>();
            //Party.Clear();
            // spawn each party member we have, as long as we're below max
            for (int i = 0; i < partyData.Count && i < _spawnLocations.Count; i++)
            {
                if (partyData[i] != null && _spawnLocations[i] != null)
                {
                    Hero newMember = SpawnMember(i, partyData[i], _parentGameObject);
                    newParty.Add(newMember);
                }
            }

            return newParty;
        }

        public Hero SpawnMember(int slotIndex, HeroData data, Transform parentGameObject)
        {
            Hero newPartyMember = Instantiate(_partyMemberPrefab, _spawnLocations[slotIndex].position, Quaternion.identity);
            // load in party member data
            newPartyMember.Initialize(data);
            // organize it in hierarchy
            newPartyMember.gameObject.name = "PartyMember_" + data.Name;
            newPartyMember.transform.SetParent(parentGameObject.transform);

            return newPartyMember;

        }
    }
}

