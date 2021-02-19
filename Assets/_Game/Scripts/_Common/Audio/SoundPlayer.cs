using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Levels.Encounter
{
    public class SoundPlayer : MonoBehaviour
    {
        [SerializeField] AudioSource _soundSource;
        [SerializeField] EncounterSoundData _encounterSounds;

        public EncounterSoundData Sounds => _encounterSounds;

        private void Awake()
        {
            ConfigurePlayer();
        }

        public void Play(AudioClip clip)
        {
            _soundSource.PlayOneShot(clip);
        }

        void ConfigurePlayer()
        {
            _soundSource.spatialBlend = 0;
            _soundSource.playOnAwake = false;
        }
    }
}

