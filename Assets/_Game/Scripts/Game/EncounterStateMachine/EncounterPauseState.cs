using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EncounterPauseState : IState
{
    EncounterSM _stateMachine = null;
    InputController _input = null;

    public EncounterPauseState(EncounterSM stateMachine, InputController input)
    {
        _stateMachine = stateMachine;
        _input = input;
    }

    public void Enter()
    {
        Debug.Log("Pause State ENTER");
        _input.Controls.Encounter.PauseGame.performed += OnPauseInput;
    }

    public void Exit()
    {
        Debug.Log("Pause State EXIT");
        _input.Controls.Encounter.PauseGame.performed -= OnPauseInput;
    }

    public void FixedTick()
    {
        
    }

    public void Tick()
    {
        
    }

    void OnPauseInput(InputAction.CallbackContext context)
    {
        Debug.Log("Pause received");
        _stateMachine.ChangeStateToPrevious();
    }
}
