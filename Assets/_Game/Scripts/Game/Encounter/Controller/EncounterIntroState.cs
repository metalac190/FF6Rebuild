using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This state sets up the primary game systems and does all the necessary loading of assets.
/// If it's required Setup for the Encounter to run properly, it should probably go here.
/// </summary>

namespace RPG.Encounter
{
    public class EncounterIntroState : IState
    {
        int _fadeInDuration = 1;

        EncounterController _controller = null;

        EnvironmentSpawner _environmentSpawner = null;
        PartySpawner _partySpawner = null;
        EnemySpawner _enemySpawner = null;
        EncounterLoader _loader = null;

        PartyHUD _partyHUD = null;
        EnemyListHUD _enemyListHUD = null;
        ScreenFader _fader = null;

        public EncounterIntroState(EncounterController controller)
        {
            _controller = controller;
            // dependencies
            _environmentSpawner = controller.Spawner.EnvironmentSpawner;
            _partySpawner = controller.Spawner.PartySpawner;
            _enemySpawner = controller.Spawner.EnemySpawner;
            _loader = controller.Spawner.Loader;

            _partyHUD = controller.HUD.PartyHUD;
            _enemyListHUD = controller.HUD.EnemyListHUD;
            _fader = controller.HUD.Fader;
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

            PlayMusic();

            _fader.Fade(1, 0, _fadeInDuration);

            Debug.Log("Play intro animations");
        }

        void PlayMusic()
        {
            MusicPlayer.Instance.PlaySong(_loader.EncounterData.Music);
        }

        private void CreateEnemyUI()
        {
            _enemyListHUD.CreateEnemyListHUD(_controller.Enemies);
            _enemyListHUD.Show();
        }

        private void CreatePartyUI()
        {
            _partyHUD.CreatePartyHUD(_controller.Party);
            _partyHUD.Show();
        }

        void SpawnEnvironment()
        {
            _environmentSpawner.Spawn(_loader.EncounterData.Environment);
        }

        void SpawnParty()
        {
            _partySpawner.SpawnNewParty(_loader.PartyDataToLoad);
        }

        private void SpawnEnemies()
        {
            EncounterGroup newEncounterGroup = _loader.GetEnemyEncounter();
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
            _controller.ChangeState(_controller.IdleState);
        }
    }
}

