using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterWinState : IState
{
    EncounterSM _stateMachine = null;

    public EncounterWinState(EncounterSM stateMachine)
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

    public void FixedTick()
    {
        
    }

    public void Tick()
    {
        
    }
}
