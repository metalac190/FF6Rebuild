using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimator : MonoBehaviour
{
    [SerializeField] Animator _animator;

    [SerializeField] Motion _introMotion;
    [SerializeField] Motion _idleMotion;
    [SerializeField] Motion _koMotion;
    [SerializeField] Motion _performingActionMotion;
    [SerializeField] Motion _preparingMotion;
    [SerializeField] Motion _waitingForActionMotion;

    const string IntroAnimation = "Intro";
    const string IdleAnimation = "Idle";
    const string KOAnimation = "KO";
    const string PerformingActionAnimation = "PerformingAction";
    const string PreparingAnimation = "Preparing";
    const string WaitingForActionAnimation = "WaitingForAction";

    public void Pause(bool isPaused)
    {

    }
}
