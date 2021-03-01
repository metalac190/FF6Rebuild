using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LeftHandEquipSlot : EquipSlot
{
    public LeftHandEquipSlot(string name) : base(name)
    {
    }

    public override bool CanEquip(Equipment equipment)
    {
        switch (equipment.EquipType)
        {
            case EquipType.OneHand:
                return true;
            case EquipType.LeftHand:
                return true;
            default:
                return false;
        }
    }
}
