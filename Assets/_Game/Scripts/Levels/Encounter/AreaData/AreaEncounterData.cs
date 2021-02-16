using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AreaEncounterData_", menuName = "Encounter/Area")]
public class AreaEncounterData : ScriptableObject
{
    [Header("Area Settings")]
    [SerializeField] AudioClip _music;
    [SerializeField] GameObject _encounterEnvironmentPrefab;
    public GameObject Environment => _encounterEnvironmentPrefab;

    [SerializeField] List<EncounterGroup> _encounterGroups = new List<EncounterGroup>();
    public List<EncounterGroup> EncounterGroups => _encounterGroups;
}
