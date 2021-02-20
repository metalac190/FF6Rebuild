using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// This state represents the 'time passing between actions'. Basically, time progresses,
/// things fill, until a turn is active/ready.
/// </summary>
namespace RPG.Encounter
{
    public class EncounterIdleState : IState
    {
        EncounterController _controller = null;

        InputController _input = null;

        public EncounterIdleState(EncounterController controller)
        {
            _controller = controller;

            _input = controller.Input;
        }

        public void Enter()
        {
            Debug.Log("STATE: Encounter Active");
            SubscribeInput();
        }

        public void Exit()
        {
            UnsubscribeInput();
        }

        private void SubscribeInput()
        {
            _input.Controls.Encounter.Up.performed += OnUpInput;
            _input.Controls.Encounter.Down.performed += OnDownInput;
            _input.Controls.Encounter.Left.performed += OnLeftInput;
            _input.Controls.Encounter.Right.performed += OnRightInput;

            _input.Controls.Encounter.Confirm.performed += OnConfirmInput;
            _input.Controls.Encounter.Cancel.performed += OnCancelInput;

            _input.Controls.Encounter.Pause.performed += OnPauseInput;
        }

        private void UnsubscribeInput()
        {
            _input.Controls.Encounter.Up.performed -= OnUpInput;
            _input.Controls.Encounter.Down.performed -= OnDownInput;
            _input.Controls.Encounter.Left.performed -= OnLeftInput;
            _input.Controls.Encounter.Right.performed -= OnRightInput;

            _input.Controls.Encounter.Confirm.performed -= OnConfirmInput;
            _input.Controls.Encounter.Cancel.performed -= OnCancelInput;

            _input.Controls.Encounter.Pause.performed -= OnPauseInput;
        }

        public void FixedUpdate()
        {

        }

        public void Update()
        {
            // check if win condition is met
        }

        void OnUpInput(InputAction.CallbackContext context)
        {
            Debug.Log("Input: Up");
        }

        void OnDownInput(InputAction.CallbackContext context)
        {
            Debug.Log("Input: Down");
        }

        void OnLeftInput(InputAction.CallbackContext context)
        {
            Debug.Log("Input: Left");
        }

        void OnRightInput(InputAction.CallbackContext context)
        {
            Debug.Log("Input: Right");
        }

        void OnConfirmInput(InputAction.CallbackContext context)
        {
            Debug.Log("Input: Confirm");
        }

        void OnCancelInput(InputAction.CallbackContext context)
        {
            Debug.Log("Input: Cancel");
        }

        void OnPauseInput(InputAction.CallbackContext context)
        {
            Debug.Log("Input: Pause");

            _controller.ChangeState(_controller.PauseState);
        }
    }
}

