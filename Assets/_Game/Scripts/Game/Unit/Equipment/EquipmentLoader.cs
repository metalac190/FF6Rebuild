using UnityEngine;
using System;

public enum UnitEquipSlots
{
    RightHand = 0,
    LeftHand,
    Head,
    Body,
    Foot,
    Relic01,
    Relic02
}
/// <summary>
/// Organize slots into a larger class. This is because sometimes equipping items
/// can affect others... for example a 2H equipment could unequip a 1H, etc.
/// </summary>
public class EquipmentLoader
{
    public event Action<Equipment> EquippedNew = delegate { };
    public event Action<Equipment> Unequipped = delegate { };

    Equipment[] _equipment;

    public EquipmentLoader()
    {
        // setup equip slots from enum
        //CreateSlots();
        int numSlots = System.Enum.GetNames(typeof(UnitEquipSlots)).Length;
        _equipment = new Equipment[numSlots];
    }

    public void Equip(Equipment newEquipment, UnitEquipSlots targetSlot)
    {
        if (newEquipment == null || !CanEquip(targetSlot, newEquipment.EquipType))
            return;

        int slotIndex = (int)targetSlot;
        // unequip old item
        Equipment oldEquipment = _equipment[slotIndex];
        if(oldEquipment != null)
        {
            Unequipped.Invoke(oldEquipment);
        }
        // replace
        _equipment[slotIndex] = newEquipment;

        EquippedNew.Invoke(newEquipment);
    }

    public void UnEquip(UnitEquipSlots slotType)
    {
        int slotIndex = (int)slotType;
        // unequip old item
        Equipment oldEquipment = _equipment[slotIndex];
    }

    bool CanEquip(UnitEquipSlots targetSlot, EquipType equipType)
    {
        // check rules and exceptions for whether they can equip the item to the item slot
        // consider moving this to inheritance later

        bool canEquip = false;
        switch (targetSlot)
        {
            case UnitEquipSlots.RightHand:
                if(equipType == EquipType.OneHand)
                    canEquip = true;
                if (equipType == EquipType.TwoHand)
                    canEquip = true;
                if (equipType == EquipType.RightHand)
                    canEquip = true;
                break;

            case UnitEquipSlots.LeftHand:
                if (equipType == EquipType.OneHand)
                    canEquip = true;
                if (equipType == EquipType.TwoHand)
                    canEquip = true;
                break;

            case UnitEquipSlots.Head:
                if (equipType == EquipType.Head)
                    canEquip = true;
                break;

            case UnitEquipSlots.Body:
                if (equipType == EquipType.Body)
                    canEquip = true;
                break;

            case UnitEquipSlots.Foot:
                if (equipType == EquipType.Foot)
                    canEquip = true;
                break;

            case UnitEquipSlots.Relic01:
                if (equipType == EquipType.Relic)
                    canEquip = true;
                break;

            case UnitEquipSlots.Relic02:
                if (equipType == EquipType.Relic)
                    canEquip = true;
                break;
        }

        return canEquip;
    }
}
