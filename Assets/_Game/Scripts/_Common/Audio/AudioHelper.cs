using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioHelper
{
    public static AudioSource PlayClip2D(AudioClip clip, float volume)
    {
        // create
        GameObject audioObject = new GameObject("2DAudio");
        AudioSource audioSource = audioObject.AddComponent<AudioSource>();
        // configure
        audioSource.clip = clip;
        audioSource.volume = volume;

        audioSource.Play();
        // destroy timer
        Object.Destroy(audioObject, clip.length);

        return audioSource;
    }
}
