using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EncounterController))]
public class EncounterSM : StateMachineMB
{
    EncounterController _encounterController = null;

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
        // get references
        _encounterController = GetComponent<EncounterController>();
        // initialize states
        IntroState = new EncounterIntroState(this, _encounterController.PartySpawner, _encounterController.PartyDataToLoad);
        ActiveState = new EncounterActiveState(this, _encounterController.Input);
        WinState = new EncounterWinState(this);
        LoseState = new EncounterLoseState(this);
        PauseState = new EncounterPauseState(this, _encounterController.Input);
        StoryState = new EncounterStoryState(this);
        FleeState = new EncounterFleeState(this);
        ExitState = new EncounterExitState(this);
    }

    private void Start()
    {
        Debug.Log("SM Start");
        Initialize(IntroState);
    }
}
