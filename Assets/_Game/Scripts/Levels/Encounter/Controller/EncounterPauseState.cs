using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EncounterPauseState : IState
{
    EncounterSM _stateMachine = null;

    InputController _input = null;
    SoundPlayer _soundPlayer;
    EncounterAudioData _audioData;

    public EncounterPauseState(EncounterSM stateMachine, EncounterController controller)
    {
        _stateMachine = stateMachine;
        // dependencies
        _input = controller.Input;
        _soundPlayer = controller.SoundPlayer;
        _audioData = controller.AudioData;
    }

    public void Enter()
    {
        Debug.Log("STATE: Encounter Pause");
        _input.Controls.Encounter.Pause.performed += OnPauseInput;
        PlayAudio(_audioData.PauseSound);
    }

    private void PlayAudio(AudioClip clip)
    {
        _soundPlayer.Play(clip);
    }

    public void Exit()
    {
        _input.Controls.Encounter.Pause.performed -= OnPauseInput;
        PlayAudio(_audioData.UnPauseSound);
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
