using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    [CreateAssetMenu(fileName = "AreaEncounterData_", menuName = "Encounter/Area")]
    public class AreaEncounterData : ScriptableObject
    {
        [Header("Area Settings")]
        [SerializeField] AudioClip _music;
        [SerializeField] GameObject _encounterEnvironmentPrefab;
        [SerializeField] List<EncounterGroup> _encounterGroups = new List<EncounterGroup>();

        public AudioClip Music => _music;
        public GameObject Environment => _encounterEnvironmentPrefab;
        public List<EncounterGroup> EncounterGroups => _encounterGroups;

        public EncounterGroup GetEnemyEncounter()
        {
            //TODO load encoutner from file
            int randomIndex = Random.Range(0, _encounterGroups.Count);
            return _encounterGroups[randomIndex];
        }
    }
}

