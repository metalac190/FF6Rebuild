using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "Units/Enemy")]
public class EnemyData : UnitData
{
    [SerializeField] Vector2 _position;
    public Vector2 Position => _position;
    // usable actions
    // stealable items
    // ai parameters
}
