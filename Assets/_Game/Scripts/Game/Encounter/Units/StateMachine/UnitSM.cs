using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace RPG.Encounter
{
    [RequireComponent(typeof(Unit))]
    public class UnitSM : StateMachineMB
    {
        Unit _unit;

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
            // initialize
            _unit = GetComponent<Unit>();
            // state
            IntroState = new UnitIntroState(this, _unit);
            IdleState = new UnitIdleState(this, _unit);
            ReadyForActionState = new UnitReadyForActionState(this, _unit);
            KOState = new UnitKOState(this, _unit);
            PausedState = new UnitPausedState(this, _unit);
            PerformingActionState = new UnitPerformingActionState(this, _unit);
            PreparingState = new UnitPreparingState(this, _unit);
            WaitingForActionState = new UnitWaitingForActionState(this, _unit);
            ExitState = new UnitExitState(this, _unit);
        }

        private void Start()
        {
            ChangeState(IntroState);
        }
    }
}

