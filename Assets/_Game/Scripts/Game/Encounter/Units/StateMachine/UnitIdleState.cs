using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG.Encounter
{
    public class UnitIdleState : IState
    {
        UnitSM _stateMachine;
        Unit _unit;

        ActionTimer _actionTimer;

        public UnitIdleState(UnitSM stateMachine, Unit unit)
        {
            _stateMachine = stateMachine;
            _unit = unit;

            _actionTimer = unit.ActionTimer;
        }

        public void Enter()
        {
            _actionTimer.CTMaxed += OnCTMaxed;
        }

        public void Exit()
        {
            _actionTimer.CTMaxed -= OnCTMaxed;
        }

        public void FixedUpdate()
        {

        }

        public void Update()
        {
            if (_unit.Active)
            {
                IncrementTurn();
            }
        }

        void OnCTMaxed()
        {
            _stateMachine.ChangeState(_stateMachine.ReadyForActionState);
        }

        void IncrementTurn()
        {
            //int ctAdjust = (96 * (_speed + 20)) / 16;
            //float ctAdjust = ((1 / 255) * _speed) * MaxCT * Time.deltaTime;
            float ctAdjust = 20 * Time.deltaTime;
            _actionTimer.CT += ctAdjust;
        }
    }
}
