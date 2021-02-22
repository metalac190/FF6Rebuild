using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    /// <summary>
    /// This state represents the time when the unit has queued an action and is waiting
    /// for their turn to execute it
    /// </summary>
    public class UnitWaitingForActionState : IState
    {
        UnitSM _stateMachine;
        Unit _unit;

        public UnitWaitingForActionState(UnitSM stateMachine, Unit unit)
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

