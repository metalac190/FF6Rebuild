using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HeroData_", menuName = "Units/Hero")]
public class HeroData : UnitData
{
    //[Header("Party Member Data")]
    //TODO it's obvious now that equipment slots need to be classes, not enums
    [Header("Starting Equipment")]
    [SerializeField] EquipmentData _rightHandData;
    [SerializeField] EquipmentData _leftHandData;
    [SerializeField] EquipmentData _headData;
    [SerializeField] EquipmentData _bodyData;
    [SerializeField] EquipmentData _footData;
    [SerializeField] EquipmentData _relic01Data;
    [SerializeField] EquipmentData _relic02Data;


    // spells
    // special
    // equipment
}
