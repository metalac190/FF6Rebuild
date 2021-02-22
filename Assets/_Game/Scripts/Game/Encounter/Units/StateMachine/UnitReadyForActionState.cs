using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    /// <summary>
    /// This state represents when a Unit's turn counter has filled and they are waiting
    /// for an action to be input by the player
    /// </summary>
    public class UnitReadyForActionState : IState
    {
        UnitSM _stateMachine;
        Unit _unit;

        public UnitReadyForActionState(UnitSM stateMachine, Unit unit)
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

