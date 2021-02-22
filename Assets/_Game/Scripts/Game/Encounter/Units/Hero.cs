using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// This class holds the current encounter data for each of the party members.
/// This is also the 'HUB' for gaining access to anything related to this party member
/// </summary>

namespace RPG.Encounter
{
    public class Hero : Unit
    {

        public void Initialize(HeroData data)
        {
            base.Initialize(data);
        }
    }
}

