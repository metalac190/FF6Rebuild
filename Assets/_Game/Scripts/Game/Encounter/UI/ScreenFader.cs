using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

/// <summary>
/// Use our screen overlay to fade in and out of scenes. We're also turning on and off the canvas
/// when we're done to better optimize things. Haven't a screen-wide 0 alpha object can cause a lot
/// of unnecessary overlapping if we don't disable it.
/// </summary>
public class ScreenFader : MonoBehaviour
{
    public event Action FadeCompleted = delegate { };
    public event Action FadeOutCompleted = delegate { };

    [SerializeField] Canvas _canvas;
    [SerializeField] Image _imageView;
    [SerializeField] Color _screenColor = Color.black;

    private void Awake()
    {
        _canvas.gameObject.SetActive(false);
    }

    public void Fade(float startAlpha, float endAlpha, float durationInSeconds)
    {
        _canvas.gameObject.SetActive(true);
        // set our screen color, with 0 alpha
        Color screenColor = new Color(_screenColor.r, _screenColor.g, _screenColor.b, startAlpha);
        _imageView.DOFade(endAlpha, durationInSeconds).OnComplete(CompleteFade);
    }

    void CompleteFade()
    {
        _canvas.gameObject.SetActive(false);
        FadeCompleted.Invoke();
    }
}
