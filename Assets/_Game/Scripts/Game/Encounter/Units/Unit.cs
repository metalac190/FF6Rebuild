using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Unit : MonoBehaviour
{
    public event Action<float> CTChanged = delegate { };
    public event Action<Unit> CTMaxed = delegate { };

    int _speed = 20;
    public int MaxCT { get; private set; } = 100;

    float _ct;
    public float CT
    {
        get => _ct;
        set
        {
            value = Mathf.Clamp(value, 0, MaxCT);
            // if we weren't at max, but are about to be...
            if(_ct != MaxCT && value == MaxCT)
            {
                CTMaxed.Invoke(this);
            }
            // if our new value is different than previous value...
            if (value != _ct)
            {
                CTChanged.Invoke(value);
            }

            _ct = value;
        }
    }

    public bool Active { get; set; } = false;


    // events
    // state machine
    // unit data
}
