using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Stat
{
    public event Action<int> Changed = delegate { };

    int _value;
    int _min = 0;
    int _max = 255;

    public int Value
    {
        get => _value;
        private set
        {
            value = Mathf.Clamp(value, _min, _max);

            if (value != _value)
                Changed.Invoke(value);

            _value = value;
        }
    }

    public Stat(int value, int min = 0, int max = 255)
    {
        _value = value;
        _min = min;
        _max = max;
    }
}
