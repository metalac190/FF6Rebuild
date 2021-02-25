using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace RPG.Encounter
{
    /// <summary>
    /// This state represents when a Unit's turn counter has filled and they are waiting
    /// for an action to be input by the player
    /// </summary>
    public class UnitReadyForActionState : IState
    {
        public event Action<Unit> ReadyForAction = delegate { };

        UnitSM _stateMachine;
        Unit _unit;

        public UnitReadyForActionState(UnitSM stateMachine, Unit unit)
        {
            _stateMachine = stateMachine;
            _unit = unit;
        }

        public void Enter()
        {
            // add to queue
        }

        public void Exit()
        {
            // remove from queue
        }

        public void FixedUpdate()
        {
            
        }

        public void Update()
        {
            
        }
    }
}

