using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterIntroState : IState
{
    EncounterSM _stateMachine = null;
    PartySpawner _partySpawner = null;
    List<PartyMemberData> _partyData = null;

    public EncounterIntroState(EncounterSM stateMachine, PartySpawner partySpawner, List<PartyMemberData> partyData)
    {
        _stateMachine = stateMachine;
        _partySpawner = partySpawner;
        _partyData = partyData;
    }

    public void Enter()
    {
        Debug.Log("STATE: Encounter Intro");
        _partySpawner.SpawnParty(_partyData);
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
