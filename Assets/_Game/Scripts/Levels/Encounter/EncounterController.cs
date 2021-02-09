using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterController : MonoBehaviour
{
    [SerializeField] AreaEncounterData _encounterData;
    public AreaEncounterData EncounterData => _encounterData;

    public List<Unit> PartyMembers;
    public List<Unit> Enemies;
}
