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
        float _fadeInDuration = .5f;
        const float IntroDelayTime = 1;
        float _elapsedTime = 0;

        EncounterSM _controller = null;

        BattleSystem _battleSystem = null;
        EnvironmentSpawner _environmentSpawner = null;
        PartySpawner _partySpawner = null;
        EnemySpawner _enemySpawner = null;
        EncounterLoader _loader = null;

        PartyHUD _partyHUD = null;
        EnemyListHUD _enemyListHUD = null;
        ScreenFader _fader = null;

        public EncounterIntroState(EncounterSM controller)
        {
            _controller = controller;
            // dependencies
            _battleSystem = controller.BattleSystem;
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

            SetupBattleSystem();
            SpawnEnvironment();

            CreatePartyUI();
            CreateEnemyUI();

            PlayMusic();

            _elapsedTime = 0;
            IntroAnimations();
        }

        private void IntroAnimations()
        {
            _fader.Fade(1, 0, _fadeInDuration);
        }

        private void SetupBattleSystem()
        {
            _battleSystem.Initialize(SpawnParty(), SpawnEnemies());
        }

        void PlayMusic()
        {
            MusicPlayer.Instance.PlaySong(_loader.EncounterData.Music);
        }

        private void CreateEnemyUI()
        {
            _enemyListHUD.CreateEnemyListHUD(_battleSystem.Enemies);
            _enemyListHUD.Show();
        }

        private void CreatePartyUI()
        {
            _partyHUD.CreatePartyHUD(_battleSystem.Party);
            _partyHUD.Show();
        }

        void SpawnEnvironment()
        {
            _environmentSpawner.Spawn(_loader.EncounterData.Environment);
        }

        private List<Hero> SpawnParty()
        {
            return _partySpawner.SpawnNewParty(_loader.PartyDataToLoad);
        }

        private List<Enemy> SpawnEnemies()
        {
            EncounterGroup newEncounterGroup = _loader.GetEnemyEncounter();
            return _enemySpawner.SpawnNewEnemies(newEncounterGroup.Enemies);
        }

        public void Exit()
        {

        }

        public void FixedUpdate()
        {

        }

        public void Update()
        {
            // wait a bit before starting battle
            _elapsedTime += Time.deltaTime;
            if(_elapsedTime >= IntroDelayTime)
            {
                _controller.ChangeState(_controller.IdleState);
            }
        }
    }
}

