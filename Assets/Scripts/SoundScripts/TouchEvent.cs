using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEvent : MonoBehaviour
{
    public AudioClip soundEffect;
    public ParticleSystem particles;

    [Range(0f, 1f)]
    public float volume = 0.5f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.volume = volume;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
             PlaySoundEffect();
            PlayParticles();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
             PlaySoundEffect();
            PlayParticles();
        }
    }

    private void PlaySoundEffect()
    {
        if (soundEffect != null && audioSource != null)
        {
            audioSource.PlayOneShot(soundEffect);
        }
    }

    private void PlayParticles()
    {
        if (particles != null)
        {
            particles.Play();
        }
    }
}
