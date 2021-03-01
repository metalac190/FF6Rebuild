using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandEquipSlot : EquipSlot
{
    public RightHandEquipSlot(string name) : base(name)
    {
    }

    public override bool CanEquip(Equipment equipment)
    {
        switch (equipment.EquipType)
        {
            case EquipType.OneHand:
                return true;
            case EquipType.RightHand:
                return true;
            default:
                return false;
        }
    }
}
