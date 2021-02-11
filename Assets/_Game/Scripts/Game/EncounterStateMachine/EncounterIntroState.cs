using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterIntroState : IState
{
    EncounterSM _stateMachine = null;
    PartySpawner _partySpawner = null;
    EnemySpawner _enemySpawner = null;
    EncounterLoader _encounterLoader = null;

    public EncounterIntroState(EncounterSM stateMachine, PartySpawner partySpawner, 
        EnemySpawner enemySpawner, EncounterLoader encounterLoader)
    {
        _stateMachine = stateMachine;
        _partySpawner = partySpawner;
        _enemySpawner = enemySpawner;
        _encounterLoader = encounterLoader;
    }

    public void Enter()
    {
        Debug.Log("STATE: Encounter Intro");
        // configure encounter data
        EncounterGroup newEncounterGroup = _encounterLoader.LoadEnemyEncounter();
        _enemySpawner.SpawnNewEnemies(newEncounterGroup.Enemies);

        _partySpawner.SpawnNewParty(_encounterLoader.PartyDataToLoad);

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
