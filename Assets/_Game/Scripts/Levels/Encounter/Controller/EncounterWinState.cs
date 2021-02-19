using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Levels.Encounter
{
    public class EncounterWinState : IState
    {
        EncounterController _stateMachine = null;

        public EncounterWinState(EncounterController stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void Enter()
        {
            Debug.Log("STATE: Encounter Win");
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

