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

        //TODO pull this from stats later
        //public int Speed { get; private set; } = 20;
        public ActionTimer ActionTimer { get; private set; }

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

        private void Awake()
        {
            

        }

        private void Start()
        {
            

            ChangeState(IntroState);
        }

        public virtual void Initialize(UnitData unitData)
        {
            // initialize values
            Name = unitData.Name;


            Stats = new UnitStats(unitData);    // grab stats from data
            //HPMax = unitData.HPMax;
            //HP = unitData.HP;
            //HPMax = unitData.MPMax;
            //MP = unitData.MP;
            //Level = unitData.Level;
                        
            Graphic = unitData.Graphic;
            _spriteView.sprite = unitData.Graphic;

            ActionTimer = new ActionTimer(Stats.Speed.Value, Stats.Initiative.Value);
            // state
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





        // events
        // state machine
        // unit data
    }
}

