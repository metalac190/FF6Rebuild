using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct EquipModification
{
    [SerializeField] StatType _statType;
    [SerializeField] float _value;
    [SerializeField] StatModifierType _modifierType;

    public StatType StatType => _statType;
    public float Value => _value;
    public StatModifierType ModifierType => _modifierType;

    public EquipModification(StatType statType, float value, StatModifierType modifierType)
    {
        _statType = statType;
        _value = value;
        _modifierType = modifierType;
    }
}
