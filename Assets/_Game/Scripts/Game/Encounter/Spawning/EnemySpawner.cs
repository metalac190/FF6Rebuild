using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] Enemy _enemyPrefab;
        [SerializeField] Transform _parentGameObject;
        [SerializeField] SpawnArea _spawnPlane;

        private void Awake()
        {
            // validate
            if (_parentGameObject == null)
                _parentGameObject = gameObject.transform;
        }

        public List<Enemy> SpawnNewEnemies(List<EnemySpawn> enemySpawns)
        {
            List<Enemy> newEnemies = new List<Enemy>();
            // spawn each enemy in our received enemy data list
            for (int i = 0; i < enemySpawns.Count; i++)
            {
                Enemy newEnemy = SpawnEnemy(enemySpawns[i], _parentGameObject);
                newEnemies.Add(newEnemy);
            }

            return newEnemies;
        }


        public Enemy SpawnEnemy(EnemySpawn enemySpawn, Transform parentGameObject)
        {
            //TODO normalize spawn position
            Vector3 newEnemyPosition = enemySpawn.NormalizedPosition;
            newEnemyPosition = _spawnPlane.GetSpawnLocation(newEnemyPosition);

            Enemy newEnemy = Instantiate(_enemyPrefab, newEnemyPosition, Quaternion.identity);
            newEnemy.Initialize(enemySpawn.Data);

            newEnemy.gameObject.name = "Enemy_" + enemySpawn.Data.Name;
            newEnemy.transform.SetParent(parentGameObject.transform);

            return newEnemy;
        }
    }
}

