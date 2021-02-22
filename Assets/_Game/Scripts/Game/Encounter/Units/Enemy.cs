using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// This class defines a basic 'enemy' type, and holds its data. It is generic by default,
/// but you can Initialize() it if you give it the appropriate enemy data
/// </summary>
public class Enemy : Unit
{
    [SerializeField] SpriteRenderer _spriteView;

    public Action<int> MaxHPChanged;
    public Action<int> HPChanged;
    public Action<int> MaxMPChanged;
    public Action<int> MPChanged;
    public Action<int> LevelChanged;

    public string Name { get; private set; }

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

    int _level;
    public int Level
    {
        get => _level;
        private set
        {
            value = Mathf.Clamp(value, 1, 99);
            if (value != _level)
                LevelChanged?.Invoke(value);
            _level = value;
        }
    }

    public Sprite Graphic { get; private set; }

    public void Initialize(EnemyData data)
    {
        // initialize values
        Name = data.Name;
        _maxHP = data.MaxHP;
        _hp = data.StartingHP;
        _maxHP = data.MaxMP;
        _mp = data.StartingMP;
        CT = data.StartingCT;
        _level = data.Level;

        Graphic = data.Graphic;

        // update object
        _spriteView.sprite = data.Graphic;
    }
}
