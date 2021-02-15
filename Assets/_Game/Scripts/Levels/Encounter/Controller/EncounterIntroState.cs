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
    EncounterEnemyListHUD _enemyListHUD = null;

    public EncounterIntroState(EncounterSM stateMachine, EncounterController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
        // dependencies
        _partySpawner = controller.PartySpawner;
        _enemySpawner = controller.EnemySpawner;
        _encounterLoader = controller.EncounterLoader;
        _partyHUD = controller.PartyHUD;
        _enemyListHUD = controller.EnemyHUD;
    }

    public void Enter()
    {
        Debug.Log("STATE: Encounter Intro");
        // configure encounter data
        SpawnUnits();
        SetupUI();
        Debug.Log("Play intro animations");
    }

    void SetupUI()
    {
        CreatePartyUI();
        CreateEnemyUI();
    }

    private void CreateEnemyUI()
    {
        _enemyListHUD.CreateEnemyListHUD(_controller.Enemies);
        _enemyListHUD.Show();
    }

    private void CreatePartyUI()
    {
        _partyHUD.CreatePartyHUD(_controller.PartyMembers);
        _partyHUD.Show();
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
