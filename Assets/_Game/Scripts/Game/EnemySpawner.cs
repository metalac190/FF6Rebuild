using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy _enemyPrefab;
    [SerializeField] Transform _parentGameObject;

    public List<Enemy> Enemies { get; private set; } = new List<Enemy>();

    private void Awake()
    {
        // validate
        if (_parentGameObject == null)
            _parentGameObject = gameObject.transform;
    }

    public void SpawnNewEnemies(List<EncounterEnemy> enemySpawns)
    {
        Enemies.Clear();
        // spawn each enemy in our received enemy data list
        foreach(EncounterEnemy enemySpawn in enemySpawns)
        {
            SpawnEnemy(enemySpawn, _parentGameObject);
        }
    }


    public void SpawnEnemy(EncounterEnemy enemySpawn, Transform parentGameObject)
    {
        Debug.Log("Spawn: " + enemySpawn.Data.Name);
        //TODO normalize spawn position
        Enemy newEnemy = Instantiate(_enemyPrefab, enemySpawn.SpawnPosition, Quaternion.identity);
        newEnemy.Initialize(enemySpawn.Data);

        newEnemy.gameObject.name = "Enemy_" + enemySpawn.Data.Name;
        newEnemy.transform.SetParent(parentGameObject.transform);

        Enemies.Add(newEnemy);
    }
}
