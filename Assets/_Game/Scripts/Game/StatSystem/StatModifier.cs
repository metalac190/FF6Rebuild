using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stat system based on tutorial in Unity Forum Thread:
/// https://forum.unity.com/threads/tutorial-character-stats-aka-attributes-system.504095/
/// </summary>
public class StatModifier
{
    public readonly float Value;
    public readonly StatModifierType Type;
    public readonly int Order;
    public readonly object Source;

    public StatModifier(float value, StatModifierType type, int order, object source)
    {
        Value = value;
        Type = type;
        Order = order;
        Source = source;
    }

    // optional ordering and source
    public StatModifier(float value, StatModifierType type) 
        : this(value, type, (int)type, null) { }
    // optional source
    public StatModifier(float value, StatModifierType type, int order) 
        : this(value, type, order, null) { }
    // optional ordering
    public StatModifier(float value, StatModifierType type, object source) 
        : this(value, type, (int)type, source) { }
}
