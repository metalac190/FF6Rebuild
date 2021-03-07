using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RPG.Encounter
{
    public class EncounterChoosingActionState : IState
    {
        EncounterSM _stateMachine;

        InputController _input;
        ActionMenuHUD _actionHUD;

        public EncounterChoosingActionState(EncounterSM stateMachine)
        {
            _stateMachine = stateMachine;

            _input = stateMachine.Input;
            _actionHUD = stateMachine.HUD.ActionMenuHUD;
        }

        public void Enter()
        {
            SubscribeInput();
            _actionHUD.Show();
        }

        public void Exit()
        {
            UnsubscribeInput();
            _actionHUD.Hide();
        }

        public void FixedUpdate()
        {

        }

        public void Update()
        {

        }

        private void SubscribeInput()
        {
            _input.Controls.Encounter.Up.performed += OnUpInput;
            _input.Controls.Encounter.Down.performed += OnDownInput;
            _input.Controls.Encounter.Confirm.performed += OnConfirmInput;
            _input.Controls.Encounter.Cancel.performed += OnCancelInput; ;
            _input.Controls.Encounter.Skip.performed += OnSkipInput;
        }

        private void UnsubscribeInput()
        {
            _input.Controls.Encounter.Up.performed -= OnUpInput;
            _input.Controls.Encounter.Down.performed -= OnDownInput;
            _input.Controls.Encounter.Confirm.performed -= OnConfirmInput;
            _input.Controls.Encounter.Cancel.performed -= OnCancelInput; ;
            _input.Controls.Encounter.Skip.performed -= OnSkipInput;
        }

        private void OnUpInput(InputAction.CallbackContext context)
        {
            Debug.Log("Navigate menu: Up");
        }

        private void OnDownInput(InputAction.CallbackContext context)
        {
            Debug.Log("Navigate menu: Down");
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

