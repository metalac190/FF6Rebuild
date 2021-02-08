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
        Debug.Log("STATE: Encounter Pause");
        _input.Controls.Encounter.Pause.performed += OnPauseInput;
    }

    public void Exit()
    {
        _input.Controls.Encounter.Pause.performed -= OnPauseInput;
    }

    public void FixedTick()
    {
        
    }

    public void Tick()
    {
        
    }

    void OnPauseInput(InputAction.CallbackContext context)
    {
        Debug.Log("Input: Pause");
        _stateMachine.ChangeStateToPrevious();
    }
}
