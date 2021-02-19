using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Levels.Encounter
{
    public class EncounterStoryState : IState
    {
        EncounterController _stateMachine = null;

        public EncounterStoryState(EncounterController stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void Enter()
        {
            Debug.Log("Encounter Story State");
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

