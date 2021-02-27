using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equip_", menuName = "Inventory/Equipment")]
public class EquipmentData : ScriptableObject
{
    [SerializeField] string _name = "...Equipment...";
    [SerializeField] Sprite _icon;
    [SerializeField] EquipSlot _equipSlot;
    [SerializeField] List<EquipModification> _modifications = new List<EquipModification>();
    [SerializeField] int _goldValue = 1;

    public string Name => _name;
    public Sprite Icon => _icon;
    public EquipSlot EquipSlot => _equipSlot;
    public int GoldValue => _goldValue;
    public List<EquipModification> Modifications => _modifications;
}
