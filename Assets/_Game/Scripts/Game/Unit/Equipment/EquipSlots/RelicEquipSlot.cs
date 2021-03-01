using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RelicEquipSlot : EquipSlot
{
    public RelicEquipSlot(string name) : base(name)
    {
    }

    public override bool CanEquip(Equipment equipment)
    {
        switch (equipment.EquipType)
        {
            case EquipType.Relic:
                return true;
            default:
                return false;
        }
    }
}
