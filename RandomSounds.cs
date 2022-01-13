using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSounds : MonoBehaviour
{
    private AudioSource source;
    public AudioClip[] sound;
    void Start() {
        source=GetComponent<AudioSource>();
        int randomSound=Random.Range(0,sound.Length);
        source.clip=sound[randomSound];
        source.Play();

    }
}
