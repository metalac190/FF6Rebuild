using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HeadEquipSlot : EquipSlot
{
    public HeadEquipSlot(string name) : base(name)
    {
    }

    public override bool CanEquip(Equipment equipment)
    {
        switch (equipment.EquipType)
        {
            case EquipType.Head:
                return true;
            default:
                return false;
        }
    }
}
