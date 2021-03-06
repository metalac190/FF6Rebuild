using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RPG.Encounter
{
    public class EncounterPauseState : IState
    {
        EncounterSM _controller = null;
        InputController _input = null;
        SoundPlayer _soundPlayer;
        PauseHUD _pauseHUD;
        BattleSystem _battleSystem;

        public EncounterPauseState(EncounterSM controller)
        {
            _controller = controller;
            _input = controller.Input;
            _soundPlayer = controller.SoundPlayer;
            _pauseHUD = controller.HUD.PauseHUD;
            _battleSystem = controller.BattleSystem;
        }

        public void Enter()
        {
            Debug.Log("STATE: Encounter Pause");

            _battleSystem.PauseProgression();

            _input.Controls.Encounter.Pause.performed += OnPauseInput;

            AudioClip pauseSound = _controller.Sounds.PauseSound;
            _soundPlayer.Play(pauseSound);

            _pauseHUD.Show();
        }

        public void Exit()
        {
            _input.Controls.Encounter.Pause.performed -= OnPauseInput;

            AudioClip unPauseSound = _controller.Sounds.UnPauseSound;
            _soundPlayer.Play(unPauseSound);

            _pauseHUD.Hide();

            _battleSystem.Progress();
        }

        public void FixedUpdate()
        {

        }

        public void Update()
        {

        }

        void OnPauseInput(InputAction.CallbackContext context)
        {
            Debug.Log("Input: Pause");
            _controller.ChangeStateToPrevious();
        }
    }
}

