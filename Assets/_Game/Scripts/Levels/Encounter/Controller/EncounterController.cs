using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Levels.Encounter
{
    public class EncounterController : StateMachineMB
    {
        [Header("General")]
        [SerializeField] InputController _input = null;
        [SerializeField] Spawner _spawner = null;
        [SerializeField] HUDController _hudController = null;
        [SerializeField] SoundPlayer _soundPlayer = null;

        public List<PartyMember> Party => _spawner.Party;
        public List<Enemy> Enemies => _spawner.Enemies;

        // states
        public EncounterIntroState IntroState { get; private set; }
        public EncounterActiveState ActiveState { get; private set; }
        public EncounterWinState WinState { get; private set; }
        public EncounterLoseState LoseState { get; private set; }
        public EncounterPauseState PauseState { get; private set; }
        public EncounterStoryState StoryState { get; private set; }
        public EncounterFleeState FleeState { get; private set; }
        public EncounterExitState ExitState { get; private set; }

        private void Awake()
        {
            // initialize states
            IntroState = new EncounterIntroState(this, _spawner, _hudController);
            ActiveState = new EncounterActiveState(this, _input);
            WinState = new EncounterWinState(this);
            LoseState = new EncounterLoseState(this);
            PauseState = new EncounterPauseState(this, _input, _soundPlayer);
            StoryState = new EncounterStoryState(this);
            FleeState = new EncounterFleeState(this);
            ExitState = new EncounterExitState(this);
        }

        private void Start()
        {
            ChangeState(IntroState);
        }
    }
}

