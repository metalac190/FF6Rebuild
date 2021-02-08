using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "Units/Unit")]
public class UnitData : ScriptableObject
{
    [Header("Base Data")]
    [SerializeField] int _maxHP = 1;
    public int MaxHP => _maxHP;

    [SerializeField] int _currentHP = 1;
    public int CurrentHP => _currentHP;

    [SerializeField] int _maxMP = 1;
    public int MaxMP => _maxMP;

    [SerializeField] int _currentMP = 1;
    public int CurrentMP => _maxMP;

    [SerializeField] int _currentAT = 20;
    public int CurrentAT => _currentAT;

    [SerializeField] int _level = 1;
    public int Level => _level;

    [SerializeField] Texture2D _graphic;
    public Texture2D Graphic => _graphic;

    [SerializeField] bool _invertDirectionFacing = false;
    public bool InverDirectionFacing => _invertDirectionFacing;

    // animations
    // status effects
    // stats
}
