using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace RPG.Encounter
{
    public class Unit : StateMachineMB
    {
        [SerializeField] SpriteRenderer _spriteView;

        public string Name { get; private set; }

        //public int HPMax { get; private set; }
        //public int HP { get; private set; }
        //public int MPMax { get; private set; }
        //public int MP { get; private set; }

        public UnitStats Stats { get; private set; }

        public HealthSystem Health { get; private set; }
        public ActionTimer ActionTimer { get; private set; }

        //TODO pull this from stats later
        //public int Speed { get; private set; } = 20;
        
        public bool IsActive { get; set; } = false;

        public Sprite Graphic { get; private set; }

        // states
        public UnitIntroState IntroState { get; private set; }
        public UnitIdleState IdleState { get; private set; }
        public UnitReadyForActionState ReadyForActionState { get; private set; }
        public UnitKOState KOState { get; private set; }
        public UnitPausedState PausedState { get; private set; }
        public UnitPerformingActionState PerformingActionState { get; private set; }
        public UnitPreparingState PreparingState { get; private set; }
        public UnitWaitingForActionState WaitingForActionState { get; private set; }
        public UnitExitState ExitState { get; private set; }

        public virtual void Initialize(UnitData unitData)
        {
            // initialize values
            Name = unitData.Name;
            Stats = new UnitStats(unitData);

            Health = new HealthSystem(unitData.HP, (int)Stats.HPMax.Value);
            ActionTimer = new ActionTimer(Stats.Speed.Value, Stats.Initiative.BaseValue);

            Graphic = unitData.Graphic;
            _spriteView.sprite = unitData.Graphic;

            // states
            IntroState = new UnitIntroState(this);
            IdleState = new UnitIdleState(this);
            ReadyForActionState = new UnitReadyForActionState(this);
            KOState = new UnitKOState(this);
            PausedState = new UnitPausedState(this);
            PerformingActionState = new UnitPerformingActionState(this);
            PreparingState = new UnitPreparingState(this);
            WaitingForActionState = new UnitWaitingForActionState(this);
            ExitState = new UnitExitState(this);
        }

        private void Start()
        {
            ChangeState(IntroState);
        }

        // events
        // state machine
        // unit data
    }
}

