using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Unit : MonoBehaviour
{
    int _speed = 20;
    public int MaxCT { get; private set; } = 100;

    public event Action<float> CTChanged = delegate { };

    float _ct;
    public float CT
    {
        get => _ct;
        protected set
        {
            value = Mathf.Clamp(value, 0, MaxCT);
            if (value != _ct)
                CTChanged.Invoke(value);
            _ct = value;
        }
    }

    public bool ShouldProgress { get; set; } = false;

    private void Update()
    {
        if (ShouldProgress)
        {
            IncrementTurn();
        }
    }

    void IncrementTurn()
    {
        //int ctAdjust = (96 * (_speed + 20)) / 16;
        //float ctAdjust = ((1 / 255) * _speed) * MaxCT * Time.deltaTime;
        float ctAdjust = 20 * Time.deltaTime;
        CT += ctAdjust;
    }
    // events
    // state machine
    // unit data
}
