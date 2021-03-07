using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatCollection
{
    private Dictionary<StatType, Stat> _statDictionary;

    public StatCollection()
    {
        _statDictionary = new Dictionary<StatType, Stat>();
    }

    public bool Contains(StatType statType) 
    {
        return _statDictionary.ContainsKey(statType);
    }

    public Stat GetStat(StatType statType)
    {
        if (Contains(statType))
            return _statDictionary[statType];
        else
            return null;
    }

    public Stat CreateStat(StatType statType, float value, float min, float max)
    {
        Stat stat = new Stat(value, min, max);
        _statDictionary.Add(statType, stat);
        return stat;
    }
}
