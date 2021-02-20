using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

[RequireComponent(typeof(CanvasGroup))]
[RequireComponent(typeof(RectTransform))]
public class MenuAnimationSimple : MenuAnimation
{
    public override event Action OnShowComplete;
    public override event Action HideCompleted;

    [Header("General Settings")]
    CanvasGroup _panelCanvasGroup = null;
    RectTransform _panelTransform = null;

    [Header("Animation In Settings")]
    [SerializeField] float _animateInTime = .5f;
    [SerializeField] Vector3 _startInScale = new Vector3(.5f, .5f, .5f);
    [Range(0,1)][SerializeField] float _startFade = 0;
    
    [Header("Animation Out Settings")]
    [SerializeField] float _animateOutTime = .25f;
    [SerializeField] Vector3 _endOutScale = new Vector3(.5f, .5f, .5f);
    [Range(0, 1)] [SerializeField] float _endFade = 0;

    Vector3 _initialScale;

    void Awake()
    {
        // references
        _panelCanvasGroup = GetComponent<CanvasGroup>();
        _panelTransform = GetComponent<RectTransform>();
        // default state
        _initialScale = _panelTransform.localScale;
    }

    public override void AnimateShow()
    {
        // initialize animation start state
        _panelTransform.localScale = _startInScale;
        _panelCanvasGroup.alpha = _startFade;
        // animate in
        _panelTransform.DOScale(_initialScale, _animateInTime);
        _panelCanvasGroup.DOFade(1, _animateInTime).OnComplete(HandleShowComplete);
    }

    public override void AnimateHide()
    {
        // initialize animation out state
        _panelTransform.localScale = _initialScale;
        _panelCanvasGroup.alpha = 1;
        // animate out
        _panelTransform.DOScale(_endOutScale, _animateOutTime);
        _panelCanvasGroup.DOFade(_endFade, _animateOutTime).OnComplete(HandleHideComplete);
    }

    void HandleShowComplete()
    {
        OnShowComplete?.Invoke();
    }

    void HandleHideComplete()
    {
        HideCompleted?.Invoke();
    }
}
