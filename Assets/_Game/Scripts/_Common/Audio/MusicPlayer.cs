using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] AudioSource _musicSource;

    private void Awake()
    {
        ConfigurePlayer();
    }

    public void Play(AudioClip newSong)
    {
        _musicSource.clip = newSong;
        _musicSource.Play();
    }

    private void ConfigurePlayer()
    {
        _musicSource.spatialBlend = 0;
        _musicSource.loop = true;
    }
}
