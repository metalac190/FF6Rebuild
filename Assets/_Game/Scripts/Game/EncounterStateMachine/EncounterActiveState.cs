using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EncounterActiveState : IState
{
    EncounterSM _stateMachine = null;

    InputController _input = null;

    public EncounterActiveState(EncounterSM stateMachine, EncounterController controller)
    {
        _stateMachine = stateMachine;

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
        
        _stateMachine.ChangeState(_stateMachine.PauseState);
    }
}
