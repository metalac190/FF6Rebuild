using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy _enemyPrefab;
    [SerializeField] Transform _parentGameObject;
    [SerializeField] SpawnArea _spawnPlane;

    public List<Enemy> Enemies { get; private set; } = new List<Enemy>();

    private void Awake()
    {
        // validate
        if (_parentGameObject == null)
            _parentGameObject = gameObject.transform;
    }

    public void SpawnNewEnemies(List<EnemySpawn> enemySpawns)
    {
        Enemies.Clear();
        // spawn each enemy in our received enemy data list
        foreach(EnemySpawn enemySpawn in enemySpawns)
        {
            SpawnEnemy(enemySpawn, _parentGameObject);
        }
    }


    public void SpawnEnemy(EnemySpawn enemySpawn, Transform parentGameObject)
    {
        //TODO normalize spawn position
        Vector3 newEnemyPosition = enemySpawn.NormalizedPosition;
        newEnemyPosition = _spawnPlane.GetSpawnLocation(newEnemyPosition);

        Enemy newEnemy = Instantiate(_enemyPrefab, newEnemyPosition, Quaternion.identity);
        newEnemy.Initialize(enemySpawn.Data);

        newEnemy.gameObject.name = "Enemy_" + enemySpawn.Data.Name;
        newEnemy.transform.SetParent(parentGameObject.transform);

        Enemies.Add(newEnemy);
    }

    /*
    public Vector3 DetermineWorldPosition(EncounterEnemy enemy)
    {

    }
    */
}
