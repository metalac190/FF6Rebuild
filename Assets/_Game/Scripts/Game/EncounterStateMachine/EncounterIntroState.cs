using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterIntroState : IState
{
    EncounterSM _stateMachine = null;

    public EncounterIntroState(EncounterSM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("STATE: Encounter Intro");
        Debug.Log("Setup Encounter Units");
        Debug.Log("Play intro animations");
    }

    public void Exit()
    {
        
    }

    public void FixedTick()
    {
        
    }

    public void Tick()
    {
        SetupComplete();    // currently no setup, transition immediately
    }

    void SetupComplete()
    {
        _stateMachine.ChangeState(_stateMachine.ActiveState);
    }
}
