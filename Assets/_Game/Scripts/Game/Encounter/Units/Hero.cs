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
