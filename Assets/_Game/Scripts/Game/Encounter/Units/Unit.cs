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
        // these are values, not stats. The reason is because we don't really need
        // 'modifiers' for current health or level... it just wouldn't make sense
        public int Level { get; private set; }
        // TODO add an MP System
        public int MP { get; private set; }

        public UnitStats Stats { get; private set; }

        public HealthSystem Health { get; private set; }
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

        public virtual void Initialize(UnitData unitData)
        {
            // initialize values
            Name = unitData.Name;
            Level = unitData.Level;
            MP = unitData.MP;

            Graphic = unitData.Graphic;
            _spriteView.sprite = unitData.Graphic;

            Stats = new UnitStats(unitData);

            SetupHealth(unitData.HP);
            SetupActionTimer();

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

        private void SetupActionTimer()
        {
            if (Stats.Contains(StatType.Speed) && Stats.Contains(StatType.Initiative))
            {
                float speed = Stats.GetStat(StatType.Speed).Value;
                float startValue = Stats.GetStat(StatType.Initiative).Value;
                ActionTimer = new ActionTimer(speed, startValue);
            }
            else
            {
                Debug.LogError("No Speed Stat on Unit");
            }
        }

        private void SetupHealth(int startingHP)
        {
            if (Stats.Contains(StatType.HPMax))
            {
                int maxHealth = (int)Stats.GetStat(StatType.HPMax).Value;
                Health = new HealthSystem(startingHP, maxHealth);
            }
            else
            {
                Debug.LogError("No Health Stat in UnitStats");
            }
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

