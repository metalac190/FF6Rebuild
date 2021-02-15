using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This struct groups enemy data with potential positions in battle. This is needed, because 'starting position'
/// isn't required for a configuration of an enemy type, it's mostly needed for spawning
/// </summary>
[System.Serializable]
public struct EnemySpawn
{
    [SerializeField] EnemyData _data;
    [SerializeField] [Range(0, 1)] float _xPos;
    [SerializeField] [Range(0, 1)] float _yPos;

    public EnemyData Data => _data;
    // convert position to 3D Space
    public Vector3 NormalizedPosition => new Vector3(_xPos, 0, _yPos);

    public EnemySpawn(EnemyData data, float xPos, float yPos)
    {
        _data = data;
        _xPos = xPos;
        _yPos = yPos;
    }
}
