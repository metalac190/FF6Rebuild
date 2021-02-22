using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace RPG.Encounter
{
    public class ActionTimer
    {
        public event Action<float> CTChanged = delegate { };
        public event Action CTMaxed = delegate { };

        public int Speed { get; set; }

        public int MaxCT { get; private set; } = 100;

        float _ct;
        public float CT
        {
            get => _ct;
            set
            {
                value = Mathf.Clamp(value, 0, MaxCT);
                // if we weren't at max, but are about to be...
                if (_ct != MaxCT && value == MaxCT)
                {
                    CTMaxed.Invoke();
                }
                // if our new value is different than previous value...
                if (value != _ct)
                {
                    CTChanged.Invoke(value);
                }

                _ct = value;
            }
        }
        
        public ActionTimer(int speed, float startingValue)
        {
            Speed = speed;
            CT = startingValue;
        }

    }
}

