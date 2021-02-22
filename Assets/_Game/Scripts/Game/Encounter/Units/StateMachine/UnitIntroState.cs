using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG.Encounter
{
    public class UnitIntroState : IState
    {
        UnitSM _stateMachine;
        Unit _unit;

        public UnitIntroState(UnitSM stateMachine, Unit unit)
        {
            _stateMachine = stateMachine;
            _unit = unit;
        }

        public void Enter()
        {
            //TODO play intro animations, then progress
        }

        public void Exit()
        {

        }

        public void FixedUpdate()
        {

        }

        public void Update()
        {
            // wait until we start progressign
            if(_unit.Active == true)
            {
                _stateMachine.ChangeState(_stateMachine.IdleState);
            }
        }
    }
}
