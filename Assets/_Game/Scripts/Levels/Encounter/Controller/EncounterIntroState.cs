using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterIntroState : IState
{
    EncounterSM _stateMachine = null;
    EncounterController _controller = null;

    PartySpawner _partySpawner = null;
    EnemySpawner _enemySpawner = null;
    EncounterLoader _encounterLoader = null;
    EncounterPartyHUD _partyHUD = null;

    public EncounterIntroState(EncounterSM stateMachine, EncounterController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
        // dependencies
        _partySpawner = controller.PartySpawner;
        _enemySpawner = controller.EnemySpawner;
        _encounterLoader = controller.EncounterLoader;
        _partyHUD = controller.PartyHUD;
    }

    public void Enter()
    {
        Debug.Log("STATE: Encounter Intro");
        // configure encounter data
        SpawnUnits();
        _partyHUD.CreatePartyHUD(_controller.PartyMembers);
        Debug.Log("Play intro animations");
    }

    private void SpawnUnits()
    {
        EncounterGroup newEncounterGroup = _encounterLoader.LoadEnemyEncounter();
        _enemySpawner.SpawnNewEnemies(newEncounterGroup.Enemies);

        _partySpawner.SpawnNewParty(_encounterLoader.PartyDataToLoad);
    }

    public void Exit()
    {
        
    }

    public void FixedUpdate()
    {
        
    }

    public void Update()
    {
        SetupComplete();    // currently no setup, transition immediately
    }

    void SetupComplete()
    {
        _stateMachine.ChangeState(_stateMachine.ActiveState);
    }
}