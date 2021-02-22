using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// This class defines a basic 'enemy' type, and holds its data. It is generic by default,
/// but you can Initialize() it if you give it the appropriate enemy data
/// </summary>

namespace RPG.Encounter
{
    public class Enemy : Unit
    {
           
        public void Initialize(EnemyData data)
        {
            base.Initialize(data);
        }
    }
}

