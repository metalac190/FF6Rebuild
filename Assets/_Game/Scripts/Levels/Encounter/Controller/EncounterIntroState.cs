using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterIntroState : IState
{
    EncounterSM _stateMachine = null;
    EncounterController _controller = null;

    EnvironmentSpawner _environmentSpawner = null;
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
        _environmentSpawner = controller.EnvironmentSpawner;
        _partySpawner = controller.PartySpawner;
        _enemySpawner = controller.EnemySpawner;
        _encounterLoader = controller.EncounterLoader;
        _partyHUD = controller.PartyHUD;
        _enemyListHUD = controller.EnemyHUD;
    }

    public void Enter()
    {
        Debug.Log("STATE: Encounter Intro");
        //TODO load encounter from file, instead of asset

        SpawnEnvironment();
        SpawnParty();
        SpawnEnemies();

        CreatePartyUI();
        CreateEnemyUI();
        Debug.Log("Play intro animations");
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

    void SpawnEnvironment()
    {
        _environmentSpawner.Spawn(_encounterLoader.EncounterData.Environment);
    }

    void SpawnParty()
    {
        _partySpawner.SpawnNewParty(_encounterLoader.PartyDataToLoad);
    }

    private void SpawnEnemies()
    {
        EncounterGroup newEncounterGroup = _encounterLoader.GetEnemyEncounter();
        _enemySpawner.SpawnNewEnemies(newEncounterGroup.Enemies);
    }

    public void Exit()
    {
        
    }

    public void FixedUpdate()
    {
        
    }

    public void Update()
    {
        SetupComplete();    // currently no setup, transition immediately after Enter finishes
    }

    void SetupComplete()
    {
        _stateMachine.ChangeState(_stateMachine.ActiveState);
    }
}
