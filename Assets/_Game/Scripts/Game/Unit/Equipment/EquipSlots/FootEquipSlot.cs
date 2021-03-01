using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FootEquipSlot : EquipSlot
{
    public FootEquipSlot(string name) : base(name)
    {
    }

    public override bool CanEquip(Equipment equipment)
    {
        switch (equipment.EquipType)
        {
            case EquipType.Foot:
                return true;
            default:
                return false;
        }
    }
}
