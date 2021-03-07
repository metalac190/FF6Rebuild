using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RPG.Encounter
{
    public class EncounterSelectTargetState : IState
    {
        EncounterSM _stateMachine;

        InputController _input;

        public EncounterSelectTargetState(EncounterSM stateMachine)
        {
            _stateMachine = stateMachine;

            _input = stateMachine.Input;
        }

        public void Enter()
        {
            _input.Controls.Encounter.Up.performed += OnUpInput;
            _input.Controls.Encounter.Down.performed += OnDownInput;
            _input.Controls.Encounter.Left.performed += OnLeftInput;
            _input.Controls.Encounter.Right.performed += OnRightInput;
            _input.Controls.Encounter.Confirm.performed += OnConfirmInput;
            _input.Controls.Encounter.Cancel.performed += OnCancelInput; ;
            _input.Controls.Encounter.Skip.performed += OnSkipInput;
        }

        public void Exit()
        {
            _input.Controls.Encounter.Up.performed -= OnUpInput;
            _input.Controls.Encounter.Down.performed -= OnDownInput;
            _input.Controls.Encounter.Left.performed -= OnLeftInput;
            _input.Controls.Encounter.Right.performed -= OnRightInput;
            _input.Controls.Encounter.Confirm.performed -= OnConfirmInput;
            _input.Controls.Encounter.Cancel.performed -= OnCancelInput; ;
            _input.Controls.Encounter.Skip.performed -= OnSkipInput;
        }

        public void FixedUpdate()
        {
            //
        }

        public void Update()
        {
            //
        }

        private void OnUpInput(InputAction.CallbackContext context)
        {
            Debug.Log("Navigate menu: Up");
        }

        private void OnDownInput(InputAction.CallbackContext context)
        {
            Debug.Log("Navigate menu: Down");
        }

        private void OnLeftInput(InputAction.CallbackContext context)
        {
            Debug.Log("Navigate menu: Left");
        }

        private void OnRightInput(InputAction.CallbackContext context)
        {
            Debug.Log("Navigate menu: Right");
        }

        private void OnConfirmInput(InputAction.CallbackContext context)
        {
            Debug.Log("Confirm:");
        }

        private void OnCancelInput(InputAction.CallbackContext context)
        {
            Debug.Log("Cancel:");
        }

        private void OnSkipInput(InputAction.CallbackContext context)
        {
            Debug.Log("Skip:");
        }
    }
}

