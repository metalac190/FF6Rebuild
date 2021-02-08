using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterSM : StateMachineMB
{
    [SerializeField] InputController _input = null;

    // states
    public EncounterIntroState IntroState { get; private set; }
    public EncounterActiveState ActiveState { get; private set; }
    public EncounterWinState WinState { get; private set; }
    public EncounterLoseState LoseState { get; private set; }
    public EncounterPauseState PauseState { get; private set; }
    public EncounterStoryState StoryState { get; private set; }
    public EncounterFleeState FleeState { get; private set; }
    public EncounterExitState ExitState { get; private set; }

    private void Awake()
    {
        // initialize states
        IntroState = new EncounterIntroState(this);
        ActiveState = new EncounterActiveState(this, _input);
        WinState = new EncounterWinState(this);
        LoseState = new EncounterLoseState(this);
        PauseState = new EncounterPauseState(this, _input);
        StoryState = new EncounterStoryState(this);
        FleeState = new EncounterFleeState(this);
        ExitState = new EncounterExitState(this);
    }

    private void Start()
    {
        ChangeState(IntroState);
    }
}
