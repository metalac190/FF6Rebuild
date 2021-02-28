using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment
{
    public string Name { get; private set; }
    public Sprite Icon { get; private set; }
    public EquipType EquipType { get; private set; }
    public int GoldValue { get; private set; }
    public List<EquipModification> Modifications { get; private set; }

    public Equipment(EquipmentData data)
    {
        Name = data.Name;
        Icon = data.Icon;
        EquipType = data.EquipType;
        GoldValue = data.GoldValue;
        Modifications = data.Modifications;
    }

    public void Equip(UnitStats unitStats)
    {
        //TODO
    }

    public void UnEquip(UnitStats unitStats)
    {
        //TODO
    }
}
