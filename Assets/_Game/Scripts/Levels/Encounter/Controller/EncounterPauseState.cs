using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RPG.Levels.Encounter
{
    public class EncounterPauseState : IState
    {
        EncounterController _stateMachine = null;

        InputController _input = null;
        SoundPlayer _soundPlayer;

        public EncounterPauseState(EncounterController stateMachine, InputController input, SoundPlayer soundPlayer)
        {
            _stateMachine = stateMachine;
            _input = input;
            _soundPlayer = soundPlayer;
        }

        public void Enter()
        {
            Debug.Log("STATE: Encounter Pause");
            _input.Controls.Encounter.Pause.performed += OnPauseInput;

            AudioClip pauseSound = _soundPlayer.Sounds.PauseSound;
            _soundPlayer.Play(pauseSound);
        }

        public void Exit()
        {
            _input.Controls.Encounter.Pause.performed -= OnPauseInput;
            _soundPlayer.Play(_soundPlayer.Sounds.UnPauseSound);
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
            _stateMachine.ChangeStateToPrevious();
        }
    }
}

