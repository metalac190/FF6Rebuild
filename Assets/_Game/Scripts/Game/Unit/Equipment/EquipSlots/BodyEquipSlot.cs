using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BodyEquipSlot : EquipSlot
{
    public BodyEquipSlot(string name) : base(name)
    {
    }

    public override bool CanEquip(Equipment equipment)
    {
        switch (equipment.EquipType)
        {
            case EquipType.Body:
                return true;
            default:
                return false;
        }
    }
}
