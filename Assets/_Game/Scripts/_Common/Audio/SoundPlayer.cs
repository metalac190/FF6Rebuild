using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;

    private void Awake()
    {
        ConfigurePlayer();
    }

    public void Play(AudioClip clip)
    {
        _audioSource.PlayOneShot(clip);
    }

    void ConfigurePlayer()
    {
        _audioSource.spatialBlend = 0;
        _audioSource.playOnAwake = false;
    }
}
