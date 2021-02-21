using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// This class holds the current encounter data for each of the party members.
/// This is also the 'HUB' for gaining access to anything related to this party member
/// </summary>

public class Hero : Unit
{
    [Header("Hero Settings")]
    [SerializeField] SpriteRenderer _spriteView;

    public string Name { get; private set; }

    public int Level { get; private set; }
    public int HP { get; private set; }
    public int HPMax { get; private set; }
    public int MP { get; private set; }
    public int MPMax { get; private set; }

    /*
    int _maxHP;
    public int MaxHP
    {
        get => _maxHP;
        private set
        {
            // validate maxHP
            if (value < 0)
                value = 0;
            // conform hp to new max
            HP = Mathf.Clamp(_hp, 0, _maxHP);
            // if it's changed, notify
            if (value != _maxHP)
                MaxHPChanged?.Invoke(value);
            // assign
            _maxHP = value;
        }
    }
    */

    /*
    int _hp;
    public int HP 
    {
        get => _hp; 
        private set
        {
            value = Mathf.Clamp(value, 0, _maxHP);
            if (value != _hp)
                HPChanged?.Invoke(value);
            _hp = value;
        } 
    }
    */

    /*
    int _maxMP;
    public int MaxMP 
    {
        get => _maxMP; 
        private set
        {
            if (value < 0)
                value = 0;
            MP = Mathf.Clamp(_mp, 0, _maxMP);
            if (value != _maxMP)
                MaxMPChanged?.Invoke(value);
            _maxMP = value;
        }
    }
    */

    /*
    int _mp;
    public int MP 
    {
        get => _mp;
        private set
        {
            value = Mathf.Clamp(value, 0, _maxMP);
            if (value != _mp)
                MPChanged?.Invoke(value);
            _mp = value;
        }
    }
    */

    /*
    int _ct;
    public int CT 
    {
        get => _ct;
        private set
        {
            value = Mathf.Clamp(value, 0, MaxCT);
            if (value != _mp)
                CTChanged?.Invoke(value);
            _ct = value;
        } 
    }
    */

    /*
    int _level;
    public int Level 
    {
        get => _level;
        private set
        {
            value = Mathf.Clamp(value, 1, MaxLevel);
            if (value != _level)
                LevelChanged?.Invoke(value);
            _level = value;
        }
    }
    */

    public Sprite Graphic { get; private set; }

    public void Initialize(HeroData data)
    {
        // initialize values
        Name = data.Name;
        HPMax = data.MaxHP;
        HP = data.StartingHP;
        MPMax = data.MaxMP;
        MP = data.StartingMP;
        Level = data.Level;
        CT = data.StartingCT;

        Graphic = data.Graphic;

        // update object
        _spriteView.sprite = data.Graphic;
    }
}
