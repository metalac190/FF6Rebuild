using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct EncounterEnemy
{
    [SerializeField] EnemyData _data;
    [SerializeField] [Range(0, 1)] float _xPos;
    [SerializeField] [Range(0, 1)] float _yPos;

    public EnemyData Data => _data;
    public Vector2 Position => new Vector2(_xPos, _yPos);

    public EncounterEnemy(EnemyData data, float xPos, float yPos)
    {
        _data = data;
        _xPos = xPos;
        _yPos = yPos;
    }
}
