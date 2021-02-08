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
        Debug.Log("Encounter Intro State");
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
        _stateMachine.ChangeState(_stateMachine.ActiveState);
    }
}
