using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Levels.Encounter
{
    public class EnvironmentSpawner : MonoBehaviour
    {
        [SerializeField] Transform _parentGroup;
        [SerializeField] Transform _spawnPoint;

        public void Spawn(GameObject environment)
        {
            GameObject newEnvironment = Instantiate(environment, _spawnPoint.position, _spawnPoint.rotation);

            newEnvironment.transform.SetParent(_parentGroup);
            newEnvironment.gameObject.name = environment.name;
        }
    }
}

