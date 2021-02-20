using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] EnvironmentSpawner _environmentSpawner = null;
        [SerializeField] PartySpawner _partySpawner = null;
        [SerializeField] EnemySpawner _enemySpawner = null;
        [SerializeField] EncounterLoader _loader = null;

        public EnvironmentSpawner EnvironmentSpawner => _environmentSpawner;
        public PartySpawner PartySpawner => _partySpawner;
        public EnemySpawner EnemySpawner => _enemySpawner;
        public EncounterLoader Loader => _loader;

        public List<PartyMember> Party => _partySpawner.Party;
        public List<Enemy> Enemies => _enemySpawner.Enemies;
    }
}

