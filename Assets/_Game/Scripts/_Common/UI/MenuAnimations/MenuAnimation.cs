using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class MenuAnimation : MonoBehaviour
{
    public abstract event Action OnShowComplete;
    public abstract event Action HideCompleted;

    public abstract void AnimateShow();
    public abstract void AnimateHide();
}
