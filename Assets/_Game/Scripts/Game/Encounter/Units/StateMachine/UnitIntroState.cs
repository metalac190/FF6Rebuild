using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG.Encounter
{
    public class UnitIntroState : IState
    {
        Unit _unit;

        public UnitIntroState(Unit unit)
        {
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
            if(_unit.IsActive == true)
            {
                _unit.ChangeState(_unit.IdleState);
            }
        }
    }
}
