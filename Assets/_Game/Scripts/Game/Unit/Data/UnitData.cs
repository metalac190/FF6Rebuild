using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "Units/Unit")]
public class UnitData : ScriptableObject
{
    [Header("Settings")]
    [SerializeField] string _name = "...";
    [SerializeField] Sprite _graphic;
    [SerializeField] int _level = 1;

    public string Name => _name;
    public Sprite Graphic => _graphic;
    public int Level => _level;

    // primary
    [Header("Primary Stats")]
    [SerializeField] int _hp = 1;
    [SerializeField] int _hpMax = 1;
    [SerializeField] int _mp = 1;
    [SerializeField] int _mpMax = 1;

    public int HP => _hp;
    public int HPMax => _hpMax;
    public int MP => _mpMax;
    public int MPMax => _mpMax;

    // battle stats
    [Header("Unit Stats")]
    [SerializeField] int _attack = 1;
    [SerializeField] int _ability = 1;
    [SerializeField] int _speed = 1;
    [SerializeField] int _stamina = 1;
    [SerializeField] int _defense = 1;
    [SerializeField] int _barrier = 1;
    [SerializeField] int _initiative = 1;

    public int Attack => _attack;
    public int Ability => _ability;
    public int Speed => _speed;
    public int Stamina => _stamina;
    public int Defense => _defense;
    public int Barrier => _barrier;
    public int Initiative => _initiative;

    [SerializeField] bool _invertFaceDirection = false;
    public bool InvertFaceDirection => _invertFaceDirection;
    // animations
    // status effects
    // stats
}
