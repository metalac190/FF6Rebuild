using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitStats
{
    const int HP_MAX = 9999;
    const int MP_MAX = 999;
    const int LEVEL_MAX = 99;
    const int GENERAL_MAX = 255;

    // leveling
    int _level = 1;
    public int Level 
    {
        get => _level;
        private set
        {
            value = Mathf.Clamp(value, 1, LEVEL_MAX);
            _level = value;
        }
    }
    public Stat HPMax;
    public Stat MPMax;

    // battle stats
    public Stat Attack;     // standard battle damage
    public Stat Ability;    // ability damage
    public Stat Speed;      // action timer speed
    public Stat Stamina;    // heatlh related

    public Stat Defense;    // standard battle defense
    public Stat Barrier;    // ability defense
    public Stat Initiative;     // modifier - start battle with higher action timer

    //TODO player stats
    public Stat EXPForLevelUp;
    public Stat APForLevelUp;

    public UnitStats(UnitData unitData)
    {
        Level = unitData.Level;
        // primary stats
        HPMax = new Stat(unitData.HPMax, 1, HP_MAX);
        MPMax = new Stat(unitData.MPMax, 1, MP_MAX);
        
        // battle stats
        Attack = new Stat(unitData.Attack, 1, GENERAL_MAX);
        Ability = new Stat(unitData.Ability, 1, GENERAL_MAX);
        Speed = new Stat(unitData.Speed, 1, GENERAL_MAX);
        Stamina = new Stat(unitData.Stamina, 1, GENERAL_MAX);
        Defense = new Stat(unitData.Defense, 1, GENERAL_MAX);
        Barrier = new Stat(unitData.Barrier, 1, GENERAL_MAX);
        Initiative = new Stat(unitData.Initiative, 1, GENERAL_MAX);
    }
}
