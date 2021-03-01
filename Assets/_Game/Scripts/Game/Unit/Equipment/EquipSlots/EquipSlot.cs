using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EquipSlot
{
    string _name = "...";

    public string Name => _name;
    public Equipment PreviouslyEquipped { get; private set; }
    public Equipment CurrentEquipped { get; private set; }

    public EquipSlot(string name)
    {
        _name = name;
    }

    public virtual bool CanEquip(Equipment equipment)
    {
        return true;
    }

    public bool Equip(Equipment equipment)
    {
        if (CanEquip(equipment) == false)
        {
            return false;
        }

        Remove();
        CurrentEquipped = equipment;

        return true;
    }

    public Equipment Remove()
    {
        PreviouslyEquipped = CurrentEquipped;
        CurrentEquipped = null;

        return PreviouslyEquipped;
    }
}
