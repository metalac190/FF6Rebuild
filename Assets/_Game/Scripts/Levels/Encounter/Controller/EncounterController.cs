using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterController : MonoBehaviour
{
    [Header("General")]
    [SerializeField] InputController _input = null;
    [SerializeField] EncounterLoader _encounterLoader = null;
    
    [Header("Spawning")]
    [SerializeField] EnvironmentSpawner _environmentSpawner = null;
    [SerializeField] PartySpawner _partySpawner = null;
    [SerializeField] EnemySpawner _enemySpawner = null;
    
    [Header("UI")]
    [SerializeField] EncounterPartyHUD _partyHUD = null;
    [SerializeField] EncounterEnemyListHUD _enemyListHUD = null;
    [SerializeField] EncounterTextDisplayHUD _textDisplayHUD = null;
    [SerializeField] EncounterActionMenuHUD _actionMenuHUD = null;

    [Header("Audio")]
    [SerializeField] SoundPlayer _soundPlayer = null;
    [SerializeField] EncounterAudioData _encounterAudioData = null;

    // Systems
    public InputController Input => _input;
    public EncounterLoader EncounterLoader => _encounterLoader;
    // Spawning
    public EnvironmentSpawner EnvironmentSpawner => _environmentSpawner;
    public PartySpawner PartySpawner => _partySpawner;
    public EnemySpawner EnemySpawner => _enemySpawner;
    // UI
    public EncounterPartyHUD PartyHUD => _partyHUD;
    public EncounterEnemyListHUD EnemyListHUD => _enemyListHUD;
    public EncounterTextDisplayHUD TextDisplayHUD => _textDisplayHUD;
    public EncounterActionMenuHUD ActionMenuHUD => _actionMenuHUD;
    // Spawned Units
    public List<PartyMember> PartyMembers => _partySpawner.Party;
    public List<Enemy> Enemies => _enemySpawner.Enemies;
    public AreaEncounterData EncounterData => _encounterLoader.EncounterData;
    // Sounds
    public SoundPlayer SoundPlayer => _soundPlayer;
    public EncounterAudioData AudioData => _encounterAudioData;
}
