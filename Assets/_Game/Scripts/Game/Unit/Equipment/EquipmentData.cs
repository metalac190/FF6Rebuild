using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EQ_", menuName = "Inventory/Equipment")]
public class EquipmentData : ScriptableObject
{
    [SerializeField] string _name = "...Equipment...";
    [SerializeField] Sprite _icon;
    [SerializeField] EquipType _equipType;
    [SerializeField] List<EquipModification> _modifications = new List<EquipModification>();
    [SerializeField] int _goldValue = 1;

    public string Name => _name;
    public Sprite Icon => _icon;
    public EquipType EquipType => _equipType;
    public int GoldValue => _goldValue;
    public List<EquipModification> Modifications => _modifications;

    /// <summary>
    /// convenience method that lets you easily create a new equipment from the data
    /// </summary>
    /// <returns></returns>
    public virtual Equipment Create()
    {
        Equipment newEquipment = new Equipment(this);
        return newEquipment;
    }
}
