using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterController : MonoBehaviour
{
    [Header("Dependences")]
    [SerializeField] InputController _input = null;
    [SerializeField] PartySpawner _partySpawner = null;
    [SerializeField] EnemySpawner _enemySpawner = null;
    [SerializeField] EncounterLoader _encounterLoader = null;
    [SerializeField] EncounterPartyHUD _partyHUD = null;

    public InputController Input => _input;
    public PartySpawner PartySpawner => _partySpawner;
    public EnemySpawner EnemySpawner => _enemySpawner;
    public EncounterLoader EncounterLoader => _encounterLoader;
    public EncounterPartyHUD PartyHUD => _partyHUD;

    public List<PartyMember> PartyMembers => _partySpawner.Party;
    public List<Enemy> Enemies => _enemySpawner.Enemies;
}
