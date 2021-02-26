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
        public event Action<bool,Unit> ReadyChanged = delegate { };

        Unit _unit;

        bool _isReadyToAct = false;
        public bool IsReadyToAct 
        {
            get => _isReadyToAct; 
            private set
            {
                // notify if changed
                if (value != _isReadyToAct)
                    ReadyChanged(value, _unit);
                _isReadyToAct = value;
            }
        }

        public UnitReadyForActionState(Unit unit)
        {
            _unit = unit;
        }

        public void Enter()
        {
            // add to queue
            IsReadyToAct = true;
        }

        public void Exit()
        {
            // remove from queue
            IsReadyToAct = false;
        }

        public void FixedUpdate()
        {
            
        }

        public void Update()
        {
            if (!IsReadyToAct)
            {
                _unit.ChangeState(_unit.IdleState);
            }
        }
    }
}

