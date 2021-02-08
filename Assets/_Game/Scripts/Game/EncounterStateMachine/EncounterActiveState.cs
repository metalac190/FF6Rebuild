using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EncounterActiveState : IState
{
    EncounterSM _stateMachine = null;
    InputController _input = null;

    public EncounterActiveState(EncounterSM stateMachine, InputController input)
    {
        _stateMachine = stateMachine;
        _input = input;
    }

    public void Enter()
    {
        Debug.Log("Active State ENTER");
        //_input.Controls.Encounter.Pause.performed += ctx => OnPauseInput();
        _input.Controls.Encounter.Up.performed += OnUpInput;
        _input.Controls.Encounter.PauseGame.performed += OnPauseGameInput;
    }

    public void Exit()
    {
        Debug.Log("Active State EXIT");
        //_input.Controls.Encounter.Pause.performed -= ctx => OnPauseInput();
        _input.Controls.Encounter.Up.performed -= OnUpInput;
        _input.Controls.Encounter.PauseGame.performed -= OnPauseGameInput;
    }

    public void FixedTick()
    {
        
    }

    public void Tick()
    {
        //Debug.Log("Active State Tick....");
    }

    void OnPauseGameInput(InputAction.CallbackContext context)
    {
        Debug.Log("Active: OnPauseInput");
        
        _stateMachine.ChangeState(_stateMachine.PauseState);
    }

    void OnUpInput(InputAction.CallbackContext context)
    {
        Debug.Log("Up pressed");
    }
}
