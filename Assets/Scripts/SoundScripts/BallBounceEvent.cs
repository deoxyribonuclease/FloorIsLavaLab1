using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceEvent : MonoBehaviour
{
    [Header("Audio Settings")]
    public AudioClip bounceSound;
    private AudioSource audioSource;
    private Rigidbody rb;

    [Range(1f, 2f)]
    public float minPitch = 1f;

    [Range(1f, 2f)]
    public float maxPitch = 2f;

    [Range(0f, 1f)]
    public float volume = 0.5f;

    [Header("Bounce Settings")]
    public float minBounceForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.volume = volume;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Race"))
        {
            float bounceForce = rb.velocity.magnitude;
            float pitch = bounceForce >= minBounceForce ? Mathf.Lerp(minPitch, maxPitch, bounceForce / 10f) : 0f;
            audioSource.pitch = pitch;
            audioSource.PlayOneShot(bounceSound);
        }
    }
}
