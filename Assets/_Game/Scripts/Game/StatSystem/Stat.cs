using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Stat system based on tutorial in Unity Forum Thread:
/// https://forum.unity.com/threads/tutorial-character-stats-aka-attributes-system.504095/
/// </summary>

[Serializable]
public class Stat
{
    public event Action<float> BaseValueChanged = delegate { };
    public event Action<float> ModifiedValueChanged = delegate { };

    private float _valueBase = 1;
    private float _min = 1;
    private float _max = 255;

    //protected float _lastBaseValue = float.MinValue;
    protected bool _isDirty = true;
    protected float _value;

    public List<StatModifier> StatModifiers { get; protected set; }

    public float BaseValue
    {
        get => _valueBase;
        set
        {
            value = Mathf.Clamp(value, _min, _max);
            // if the value has changed
            if(_valueBase != value)
            {
                _valueBase = value;
                _isDirty = true;
                BaseValueChanged.Invoke(value);
            }
        }

    }

    public float Value
    {
        get
        {
            if (_isDirty)
            {
                _value = CalculateModifiedValue();
                _isDirty = false;
            }
            return _value;
        }
    }

    public Stat()
    {
        StatModifiers = new List<StatModifier>();
    }

    public Stat(float valueBase, float baseMin, float baseMax) : this()
    {
        _min = baseMin;
        _max = baseMax;

        _valueBase = Mathf.Clamp(valueBase, baseMin, baseMax);
    }

    public virtual void AddModifier(StatModifier modifier)
    {
        _isDirty = true;
        StatModifiers.Add(modifier);
        StatModifiers.Sort(CompareModifierOrder);
    }

    public virtual bool RemoveModifier(StatModifier modifier)
    {
        if (StatModifiers.Remove(modifier))
        {
            _isDirty = true;
            return true;
        }
        return false;
    }

    public virtual bool RemoveAllModifiersFromSource(object source)
    {
        bool didRemove = false;
        foreach(StatModifier modifier in StatModifiers)
        {
            if(modifier.Source == source)
            {
                _isDirty = true;
                didRemove = true;
                //TODO check this code
                StatModifiers.Remove(modifier);
            }
        }
        return didRemove;
    }

    protected virtual float CalculateModifiedValue()
    {
        float finalValue = BaseValue;
        float sumPercentAdd = 0;    // so that we can add %'s before final multiply

        //TODO these enums should be converted into a class
        for (int i = 0; i < StatModifiers.Count; i++)
        {
            StatModifier modifier = StatModifiers[i];
            // todo use Inheritance for this later
            if (modifier.Type == StatModifierType.Flat)
            {
                finalValue += modifier.Value;
            }
            else if (modifier.Type == StatModifierType.PercentAdd)
            {
                sumPercentAdd += modifier.Value;
                // if we're at the end of th elist OR the next modifier isn't of this type
                if (i + 1 >= StatModifiers.Count || StatModifiers[i + 1].Type != StatModifierType.PercentAdd)
                {
                    float percentAsProportion = 1 + (sumPercentAdd / 100);
                    finalValue *= percentAsProportion;    // multiply our running percentage so far
                    sumPercentAdd = 0;
                }
            }
            else if (modifier.Type == StatModifierType.PercentMultiply)
            {
                // calculate decimal from 1 and multiply (Ex. 1 + -.2 = -.8)
                float percentAsProportion = 1 + (modifier.Value / 100);
                finalValue *= percentAsProportion;
            }
        }
        // round for cleanliness, and to avoid float calc messiness
        return (float)Math.Round(finalValue, 4);
    }

    protected virtual int CompareModifierOrder(StatModifier a, StatModifier b)
    {
        if (a.Order < b.Order)
            return -1;
        else if (a.Order > b.Order)
            return 1;
        return 0;   // if (a.Order == b.Order)
    }
}
