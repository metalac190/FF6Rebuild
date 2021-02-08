using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterController : MonoBehaviour
{
    [SerializeField] EncounterData _encounterData;
    public EncounterData EncounterData => _encounterData;

    public List<Unit> PartyMembers;
    public List<Unit> Enemies;
}
