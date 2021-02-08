using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// This script just helps reduce the weird setup linking with Unity's
/// new Input system. We set it up once here, and then other scripts can
/// access it.
/// </summary>
public class InputController : MonoBehaviour
{
    public Controls Controls { get; private set; }

    void Awake()
    {
        Controls = new Controls();
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }
}
