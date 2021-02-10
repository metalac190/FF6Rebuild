using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "Units/Unit")]
public class UnitData : ScriptableObject
{
    [Header("Base Data")]
    [SerializeField] string _name = "...";
    public string Name => _name;

    [SerializeField] int _maxHP = 1;
    public int MaxHP => _maxHP;

    [SerializeField] int _startingHP = 1;
    public int StartingHP => _startingHP;

    [SerializeField] int _maxMP = 1;
    public int MaxMP => _maxMP;

    [SerializeField] int _startingMP = 1;
    public int StartingMP => _maxMP;

    [SerializeField] int _ct = 20;
    public int StartingCT => _ct;

    [SerializeField] int _level = 1;
    public int Level => _level;

    [SerializeField] Sprite _graphic;
    public Sprite Graphic => _graphic;

    [SerializeField] bool _invertFaceDirection = false;
    public bool InvertFaceDirection => _invertFaceDirection;

    // animations
    // status effects
    // stats
}
