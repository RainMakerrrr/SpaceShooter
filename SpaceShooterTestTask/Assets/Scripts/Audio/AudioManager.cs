using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private Sound[] _sounds;

    public static AudioManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        foreach(var sound in _sounds)
        {
            sound.AudioSource = gameObject.AddComponent<AudioSource>();
            sound.AudioSource.clip = sound.AudioClip;
            sound.AudioSource.volume = sound.Volume;
            sound.AudioSource.pitch = sound.Pitch;
        }
    }

    public void Play(int index)
    {
        var newSound = Array.Find(_sounds, sound => sound.Index == index);
        newSound.AudioSource.Play();
    }
}
