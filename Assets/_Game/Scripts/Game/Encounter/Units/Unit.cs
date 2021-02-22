using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace RPG.Encounter
{
    public class Unit : MonoBehaviour
    {
        [SerializeField] SpriteRenderer _spriteView;

        public string Name { get; private set; }

        public int HPMax { get; private set; }
        public int HP { get; private set; }
        public int MPMax { get; private set; }
        public int MP { get; private set; }
        public int Level { get; private set; }
        public int StartingActionTime { get; private set; }

        //TODO pull this from stats later
        public int Speed { get; private set; } = 20;
        public ActionTimer ActionTimer { get; private set; }
        public bool Active { get; set; } = false;

        public Sprite Graphic { get; private set; }

        private void Awake()
        {
            ActionTimer = new ActionTimer(Speed, StartingActionTime);
        }

        public void Initialize(UnitData unitData)
        {
            // initialize values
            Name = unitData.Name;
            HPMax = unitData.MaxHP;
            HP = unitData.StartingHP;
            HPMax = unitData.MaxMP;
            MP = unitData.StartingMP;
            StartingActionTime = unitData.StartingCT;
            Level = unitData.Level;

            Graphic = unitData.Graphic;
            _spriteView.sprite = unitData.Graphic;
        }

        // events
        // state machine
        // unit data
    }
}

