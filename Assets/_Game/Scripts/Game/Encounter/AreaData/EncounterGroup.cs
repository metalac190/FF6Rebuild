using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    [System.Serializable]
    public struct EncounterGroup
    {
        [SerializeField] string _name;
        [SerializeField] List<EnemySpawn> _enemies;
        public List<EnemySpawn> Enemies => _enemies;

        public EncounterGroup(string name, List<EnemySpawn> enemies)
        {
            _name = name;
            _enemies = new List<EnemySpawn>();
            _enemies = enemies;
        }
    }
}

