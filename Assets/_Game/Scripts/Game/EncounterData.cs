using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEncounter", menuName = "Encounter/Standard")]
public class EncounterData : ScriptableObject
{
    [SerializeField] List<EncounterEnemy> _enemies = new List<EncounterEnemy>();
    public List<EncounterEnemy> Enemies => _enemies;
}
