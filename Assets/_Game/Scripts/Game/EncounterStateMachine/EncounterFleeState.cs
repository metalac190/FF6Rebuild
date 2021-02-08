using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterFleeState : IState
{
    EncounterSM _stateMachine = null;

    public EncounterFleeState(EncounterSM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("Encounter Flee State");
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
