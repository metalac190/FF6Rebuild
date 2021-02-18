using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : Singleton<MusicPlayer>
{
    [SerializeField] AudioSource _source;

    Coroutine _fadeRoutine = null;

    public float Volume
    {
        get => _source.volume;
        private set
        {
            value = Mathf.Clamp(value, 0, 1);
            _source.volume = value;
        }
    }

    public void PlaySong(AudioClip clip)
    {
        _source.clip = clip;
        _source.Play();
    }

    public void Continue()
    {
        _source.Play();
    }

    public void Pause()
    {
        _source.Pause();
    }

    public void Stop()
    {
        _source.Stop();
    }

    public void FadeVolume(float targetVolume, float fadeTime)
    {
        if (_fadeRoutine != null)
            StopCoroutine(_fadeRoutine);
        _fadeRoutine = StartCoroutine(FadeVolumeRoutine(targetVolume, fadeTime));
    }

    IEnumerator FadeVolumeRoutine(float targetVolume, float fadeTime)
    {
        float startingVolume = Volume;
        // fade volume over time
        for (float elapsedTime = 0; elapsedTime <= fadeTime; elapsedTime += Time.deltaTime)
        {
            float newVolume = Mathf.Lerp(startingVolume, targetVolume, elapsedTime / fadeTime);
            _source.volume = newVolume;
            // wait for next cycle
            yield return null;
        }
        // ensure we hit the target
        Volume = targetVolume;
    }
}
