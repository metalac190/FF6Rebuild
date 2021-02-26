using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Stat
{
    public event Action<int> Changed = delegate { };

    [SerializeField] int _value = 1;

    int _min = 1;
    int _max = 255;

    public int Value
    {
        get => _value;
        set
        {
            value = Mathf.Clamp(value, _min, _max);

            if (value != _value)
                Changed.Invoke(value);

            _value = value;
        }
    }

    public Stat(int value, int min, int max)
    {
        _min = min;
        _max = max;
        Value = value;
    }
}
