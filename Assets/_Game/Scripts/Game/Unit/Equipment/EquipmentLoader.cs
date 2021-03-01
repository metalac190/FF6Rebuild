using UnityEngine;
using System;

/// <summary>
/// Organize slots into a larger class. This is because sometimes equipping items
/// can affect others... for example a 2H equipment could unequip a 1H, etc.
/// </summary>

[System.Serializable]
public class EquipmentLoader
{
    // event ("new equipment", "old equipment")
    public event Action<Equipment,Equipment> EquipmentChanged = delegate { };

    EquipSlot[] _equipSlots;

    public EquipmentLoader(EquipSlot[] equipSlots)
    {
        // setup equip slots from enum
        _equipSlots = equipSlots;
    }

    public void Equip(int equipSlotIndex, Equipment newEquipment)
    {
        EquipSlot slot = _equipSlots[equipSlotIndex];
        // equip it if we can, notify if successful
        if (slot.Equip(newEquipment))
        {
            Equipment oldEquipment = slot.PreviouslyEquipped;
            EquipmentChanged.Invoke(oldEquipment, newEquipment);
        }
    }

    public void Remove(int equipSlotIndex)
    {
        EquipSlot slot = _equipSlots[equipSlotIndex];
        Equipment oldEquipment = slot.Remove();
        if(oldEquipment != null)
        {
            EquipmentChanged.Invoke(oldEquipment, null);
        }
    }
}
