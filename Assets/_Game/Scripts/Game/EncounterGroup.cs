using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct EncounterGroup
{
    [SerializeField] List<EncounterEnemy> _enemies;
    public List<EncounterEnemy> Enemies => _enemies;

    public EncounterGroup(List<EncounterEnemy> enemies)
    {
        _enemies = new List<EncounterEnemy>();
        _enemies = enemies;
    }
}
