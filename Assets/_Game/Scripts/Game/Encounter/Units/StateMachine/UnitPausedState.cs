using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG.Encounter
{
    public class UnitPausedState : IState
    {
        UnitSM _stateMachine;
        Unit _unit;

        public UnitPausedState(UnitSM stateMachine, Unit unit)
        {
            _stateMachine = stateMachine;
            _unit = unit;
        }

        public void Enter()
        {

        }

        public void Exit()
        {

        }

        public void FixedUpdate()
        {

        }

        public void Update()
        {

        }
    }
}
