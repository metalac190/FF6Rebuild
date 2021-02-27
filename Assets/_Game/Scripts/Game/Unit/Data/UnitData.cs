using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "Units/Unit")]
public class UnitData : ScriptableObject
{
    [Header("Basic Stats")]
    [SerializeField] string _name = "...";
    public string Name => _name;

    [SerializeField] Sprite _graphic;
    public Sprite Graphic => _graphic;

    [SerializeField] int _level = 1;
    public int Level => _level;

    // primary
    [Header("Primary Stats")]
    [SerializeField] int _hp = 1;
    public int HP => _hp;

    [SerializeField] int _hpMax = 1;
    public int HPMax => _hpMax;

    [SerializeField] int _mp = 1;
    public int MP => _mpMax;

    [SerializeField] int _mpMax = 1;
    public int MPMax => _mpMax;

    // battle stats
    [Header("Battle Stats")]
    [SerializeField] int _attack = 1;
    public int Attack => _attack;

    [SerializeField] int _ability = 1;
    public int Ability => _ability;

    [SerializeField] int _speed = 1;
    public int Speed => _speed;

    [SerializeField] int _stamina = 1;
    public int Stamina => _stamina;

    [SerializeField] int _defense = 1;
    public int Defense => _defense;

    [SerializeField] int _barrier = 1;
    public int Barrier => _barrier;

    [SerializeField] int _initiative = 1;
    public int Initiative => _initiative;


    [SerializeField] bool _invertFaceDirection = false;
    public bool InvertFaceDirection => _invertFaceDirection;
    // animations
    // status effects
    // stats
}
