using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitStats : StatCollection
{
    UnitData _unitData;

    public UnitStats(UnitData unitData)
    {
        _unitData = unitData;

        // primary stats
        CreateStat(StatType.HPMax, _unitData.HPMax, 1, 9999);
        CreateStat(StatType.MPMax, _unitData.MPMax, 1, 999);

        // battle stats
        CreateStat(StatType.Attack, _unitData.Attack, 1, 255);
        CreateStat(StatType.Ability, _unitData.Ability, 1, 255);
        CreateStat(StatType.Speed, _unitData.Speed, 1, 255);
        CreateStat(StatType.Stamina, _unitData.Stamina, 1, 255);
        CreateStat(StatType.Defense, _unitData.Defense, 1, 255);
        CreateStat(StatType.Barrier, _unitData.Barrier, 1, 255);
        CreateStat(StatType.Initiative, _unitData.Initiative, 1, 255);
    }
}
