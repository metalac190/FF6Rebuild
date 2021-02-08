using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterExitState : IState
{
    EncounterSM _stateMachine = null;

    public EncounterExitState(EncounterSM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("Encounter Exit State");
    }

    public void Exit()
    {
        
    }

    public void FixedTick()
    {
        
    }

    public void Tick()
    {
        
    }
}
