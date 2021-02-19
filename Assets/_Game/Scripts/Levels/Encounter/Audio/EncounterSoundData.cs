using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// These sounds are associated with the common gameplay sounds during
/// the Encounter battle system. These are grouped in a single data object
/// to make common soundFX easier to access in a single place.
/// </summary>

namespace RPG.Levels.Encounter
{
    [CreateAssetMenu(fileName = "EncounterAudio", menuName = "Encounter/Audio")]
    public class EncounterSoundData : ScriptableObject
    {
        [Header("System Sounds")]
        [SerializeField] AudioClip _pauseSound;
        [SerializeField] AudioClip _unPauseSound;
        [SerializeField] AudioClip _unitActivatedSound;

        [Header("Menu Sounds")]
        [SerializeField] AudioClip _moveCursorSound;
        [SerializeField] AudioClip _menuConfirmSound;
        [SerializeField] AudioClip _menuCancelSound;

        [Header("Common Music")]
        [SerializeField] AudioClip _victoryMusic;

        public AudioClip PauseSound => _pauseSound;
        public AudioClip UnPauseSound => _unPauseSound;
        public AudioClip UnitActivatedSound => _unitActivatedSound;

        public AudioClip MoveCursorSound => _moveCursorSound;
        public AudioClip MenuConfirmSound => _menuConfirmSound;
        public AudioClip MenuCancelSound => _menuCancelSound;

        public AudioClip VictoryMusic => _victoryMusic;
    }
}

