using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RPG.Encounter
{
    public class EncounterPauseState : IState
    {
        EncounterController _controller = null;
        InputController _input = null;
        SoundPlayer _soundPlayer;
        PauseHUD _pauseHUD;

        public EncounterPauseState(EncounterController controller)
        {
            _controller = controller;
            _input = controller.Input;
            _soundPlayer = controller.SoundPlayer;
            _pauseHUD = controller.HUD.PauseHUD;
        }

        public void Enter()
        {
            Debug.Log("STATE: Encounter Pause");

            _input.Controls.Encounter.Pause.performed += OnPauseInput;

            AudioClip pauseSound = _soundPlayer.Sounds.PauseSound;
            _soundPlayer.Play(pauseSound);

            _pauseHUD.Show();
        }

        public void Exit()
        {
            _input.Controls.Encounter.Pause.performed -= OnPauseInput;

            AudioClip unPauseSound = _soundPlayer.Sounds.UnPauseSound;
            _soundPlayer.Play(unPauseSound);

            _pauseHUD.Hide();
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

