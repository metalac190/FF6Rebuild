using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// This class handles some basic functionality for generic canvas hide/show ability.
/// This should be attached to a parent that is above the canvas, so that it can remain active,
/// while handling the Canvas active state. If we designate an animation, the panel can animate,
/// if not, it will just disable.
/// </summary>
public abstract class HUD : MonoBehaviour
{
    [Header("Base Settings")]
    [SerializeField] Canvas _canvas = null;
    protected Canvas Canvas => _canvas;
    [SerializeField] MenuAnimation _animatedPanel = null;

    private void Awake()
    {
        // off by default
        _canvas.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        if (_animatedPanel != null)
            _animatedPanel.HideCompleted += OnHideCompleted;
    }

    private void OnDisable()
    {
        if(_animatedPanel != null)
            _animatedPanel.HideCompleted -= OnHideCompleted;
    }

    public virtual void Show()
    {
        _canvas.gameObject.SetActive(true);
        // if we have an animation, animate it
        _animatedPanel?.AnimateShow();
    }

    public virtual void Hide()
    {
        if (_animatedPanel != null)
        {
            _animatedPanel?.AnimateHide();
        }
        else
        {
            _canvas.gameObject.SetActive(false);
        }
    }

    void OnHideCompleted()
    {
        _canvas.gameObject.SetActive(false);
    }
}
