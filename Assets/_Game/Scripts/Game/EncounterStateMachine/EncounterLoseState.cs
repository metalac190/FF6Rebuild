using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterLoseState : IState
{
    EncounterSM _stateMachine = null;

    public EncounterLoseState(EncounterSM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("Encounter Lose State");
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
