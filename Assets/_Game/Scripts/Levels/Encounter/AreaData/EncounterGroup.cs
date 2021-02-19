using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Levels.Encounter
{
    [System.Serializable]
    public struct EncounterGroup
    {
        [SerializeField] List<EnemySpawn> _enemies;
        public List<EnemySpawn> Enemies => _enemies;

        public EncounterGroup(List<EnemySpawn> enemies)
        {
            _enemies = new List<EnemySpawn>();
            _enemies = enemies;
        }
    }
}

